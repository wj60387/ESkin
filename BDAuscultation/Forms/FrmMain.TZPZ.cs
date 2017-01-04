using BDAuscultation.Devices;
using BDAuscultation.Forms;
using BDAuscultation.Utilities;
using ProtocalData.Protocol.Derive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows.Forms;
namespace BDAuscultation
{
    /// <summary>
    /// 听诊配置
    /// </summary>
    partial class FrmMain
    {

        void InitdgvTZPZ()
        {
            dgvTZQPZStetNO.FillWeight = 200;

            var btnEditColumn = new DataGridViewButtonExColumn("",
               BDAuscultation.Properties.Resources.编辑点击, BDAuscultation.Properties.Resources.编辑未点击) { Name = "dgvTZQPZEdit", HeaderText = "", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,FillWeight = 50 };
            this.dgvTZQPZ.Columns.Add(btnEditColumn);
            var btnDelColumn = new DataGridViewButtonExColumn("",
                BDAuscultation.Properties.Resources.删除点击状态, BDAuscultation.Properties.Resources.删除未点击) { Name = "dgvTZQPZDelete", HeaderText = "", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,FillWeight=50 };
            this.dgvTZQPZ.Columns.Add(btnDelColumn);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器编号);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.计算机名);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊类型);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器名字);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器所属人);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器描述);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.听诊器备注);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.连接状态);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.编辑);
            dgvTZQPZ.ListColumnImage.Add(BDAuscultation.Properties.Resources.删除);
            LoadStetInfoTZPZ();
            this.btnTZPZ.Click += new System.EventHandler(this.btnTZPZ_Click);
            dgvTZQPZ.CellClick += dgvTZQPZ_CellClick;
            foreach (DataGridViewColumn column in dgvTZQPZ.Columns )
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        void dgvTZQPZ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                var stetName = dgvTZQPZ.Rows[e.RowIndex].Cells[0].Value.ToString();
                var stetInfo = Setting.GetStetInfoByStetName(stetName);
                switch (dgvTZQPZ.Columns[e.ColumnIndex].Name)
                {
                    case "dgvTZQPZEdit":
                        {

                            var formStetInfo = new FrmStetInfo()
                            {
                                StetName = stetName,
                                StetChineseName = stetInfo.StetChineseName,
                                StetOwner = stetInfo.Owner,
                                StetFuncDescript = stetInfo.FuncDescript,
                                StetRemark = stetInfo.ReMark,
                                StetType = stetInfo.StetType
                            };
                            formStetInfo.StartPosition = FormStartPosition.CenterParent;
                            if (DialogResult.OK == formStetInfo.ShowDialog())
                            {

                                StetInfoCode stetInfoCode = new StetInfoCode()
                                {
                                    StetName = formStetInfo.StetName,
                                    StetChineseName = formStetInfo.StetChineseName,
                                    SN = Setting.authorizationInfo.AuthorizationNum,
                                    MAC = Setting.authorizationInfo.MachineCode,
                                    Owner = formStetInfo.StetOwner,
                                    PCName = CommonUtil.GetMachineName(),
                                    FuncDescript = formStetInfo.StetFuncDescript,
                                    ReMark = formStetInfo.StetRemark,
                                    StetType = formStetInfo.StetType
                                };
                                HandleMessage(stetInfoCode);
                                if (Setting.isConnected)
                                {

                                    var code = Newtonsoft.Json.JsonConvert.SerializeObject(stetInfoCode);
                                    using (OperationContextScope scope = new OperationContextScope(Mediator.remoteService.InnerChannel))
                                    {
                                        MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", Setting.authorizationInfo.AuthorizationNum);
                                        OperationContext.Current.OutgoingMessageHeaders.Add(header);
                                        header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", Setting.authorizationInfo.MachineCode);
                                        OperationContext.Current.OutgoingMessageHeaders.Add(header);
                                        if (Mediator.remoteService.UpdateStetInfo(code))
                                        {
                                            Mediator.ShowMsg("编辑听诊器 " + stetName + " 信息，并上传服务器成功...");
                                            Mediator.WriteLog(this.Name, "编辑听诊器 " + formStetInfo.StetName + " 信息成功...,调用的后台方法是UpdateStetInfo");
                                            return;
                                        }
                                        Mediator.ShowMsg("编辑听诊器 " + stetName + " 信息，并上传服务器失败...");
                                        Mediator.WriteLog(this.Name, "编辑听诊器 " + formStetInfo.StetName + " 信息失败...,调用的后台方法是UpdateStetInfo");
                                    }
                                }
                            }
                        }
                        break;
                    case "dgvTZQPZDelete":
                        {

                            if (DialogResult.OK == MessageBox.Show("您确定要清空此听诊器信息？", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                            {
                                var code = new StetInfoDelCode()
                                {
                                    StetName = stetName,
                                    MAC = Setting.authorizationInfo.MachineCode
                                };
                                HandleMessage(code);
                                if (Setting.isConnected)
                                {
                                    string sql = "update StethoscopeManager set IfDel=1  where StetName={0}  and MAC={1} and IfDel=0";
                                    using (OperationContextScope scope = new OperationContextScope(Mediator.remoteService.InnerChannel))
                                    {
                                        MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", Setting.authorizationInfo.AuthorizationNum);
                                        OperationContext.Current.OutgoingMessageHeaders.Add(header);
                                        header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", Setting.authorizationInfo.MachineCode);
                                        OperationContext.Current.OutgoingMessageHeaders.Add(header);
                                        if (Mediator.remoteService.ExecuteNonQuery(sql, new string[] { stetName, Setting.authorizationInfo.MachineCode }) > 0)
                                        {

                                            Mediator.ShowMsg("删除听诊器 " + stetName + " 信息成功...");
                                            Mediator.WriteLog(this.Name, "删除听诊器 " + stetName + " 信息成功...执行的SQL是:" + sql + "参数是:" + stetName + Setting.authorizationInfo.MachineCode);
                                            return;
                                        }
                                        Mediator.ShowMsg("删除听诊器 " + stetName + " 信息失败...");
                                        Mediator.WriteLog(this.Name, "删除听诊器 " + stetName + " 信息成功...");
                                    }
                                }
                            }
                        }
                        break;
                }
            }
        }

        
        public void HandleMessage(StetInfoDelCode message)
        {
            string sql = "delete from StetInfo where MAC={0} and StetName={1}";
            int count = Mediator.sqliteHelper.ExecuteNonQuery(sql, message.MAC, message.StetName);
            if (count > 0)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    LoadStetInfoTZPZ();
                    MessageBox.Show("删除信息成功..");
                }));
            }
        }
        public void ConfigStet(string StetName)
        {
            var info = Setting.GetStetInfoByStetName(StetName);
            var formStetInfo = new FrmStetInfo()
            {
                StetOwner = info.Owner,
                StetName = info.StetName,
                StetChineseName = info.StetChineseName,
                StetFuncDescript = info.FuncDescript,
                StetRemark = info.ReMark,
                StetType = info.StetType
            };
            formStetInfo.StartPosition = FormStartPosition.CenterParent;
            if (DialogResult.OK == formStetInfo.ShowDialog())
            {
                StetInfoCode stetInfoCode = new StetInfoCode()
                {
                    StetName = formStetInfo.StetName,
                    StetChineseName = formStetInfo.StetChineseName,
                    SN = Setting.authorizationInfo.AuthorizationNum,
                    PCName = CommonUtil.GetMachineName(),
                    MAC = Setting.authorizationInfo.MachineCode,
                    Owner = formStetInfo.StetOwner,
                    FuncDescript = formStetInfo.StetFuncDescript,
                    ReMark = formStetInfo.StetRemark,
                    StetType = formStetInfo.StetType
                };
                var code = Newtonsoft.Json.JsonConvert.SerializeObject(stetInfoCode);
                using (OperationContextScope scope = new OperationContextScope(Mediator.remoteService.InnerChannel))
                {
                    MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", Setting.authorizationInfo.AuthorizationNum);
                    OperationContext.Current.OutgoingMessageHeaders.Add(header);
                    header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", Setting.authorizationInfo.MachineCode);
                    OperationContext.Current.OutgoingMessageHeaders.Add(header);

                    if (Mediator.remoteService.UpdateStetInfo(code))
                    {
                        HandleMessage(stetInfoCode);
                        Mediator.ShowMsg("新增听诊器 " + formStetInfo.StetName + " 信息，并上传服务器成功...");
                        return;
                    }
                    Mediator.ShowMsg("新增听诊器 " + formStetInfo.StetName + " 信息，并上传服务器失败...");
                }
            }
            LoadStetInfoTZPZ();
        }
        void LoadStetInfoTZPZ()
        {
            cbBoxTZPZ.Items.Clear();
            dgvTZQPZ.Rows.Clear();
            foreach (var item in StethoscopeManager.StethoscopeList)
            {
                var stetInfo = Setting.GetStetInfoByStetName(item.Name);
                if (stetInfo == null || string.IsNullOrEmpty(stetInfo.StetChineseName))
                    cbBoxTZPZ.Items.Add(item.Name);

                else
                {
                    //dgvTZQPZ.Rows.Add(stetInfo.StetName, stetInfo.MAC, stetInfo.PCName, Setting.GetPatientNameByType(stetInfo.StetType), stetInfo.StetChineseName, stetInfo.Owner, stetInfo.FuncDescript, stetInfo.ReMark);
                    dgvTZQPZ.Rows.Add(stetInfo.StetName,   stetInfo.PCName, Setting.GetPatientNameByType(stetInfo.StetType), stetInfo.StetChineseName, stetInfo.Owner, stetInfo.FuncDescript, stetInfo.ReMark,item.IsConnected?"已连接":"未连接");
                }
            }
            if (cbBoxTZPZ.Items.Count > 0)
                cbBoxTZPZ.SelectedIndex = 0;
        }
        public void HandleMessage(StetInfoCode message)
        {
            string querySql = "select * from StetInfo where StetName={0} and SN={1} and MAC={2} ";
            if (Mediator.sqliteHelper.ExecuteScalar(querySql, message.StetName, message.SN, message.MAC) != null)
            {
                string updateSql = "update StetInfo set StetChineseName={0},Owner={1},FuncDescript={2},ReMark={3},PCName={7} ,StetType={8} where StetName={4} and SN={5} and MAC={6}";
                var count = Mediator.sqliteHelper.ExecuteNonQuery(updateSql, message.StetChineseName, message.Owner, message.FuncDescript, message.ReMark, message.StetName, message.SN, message.MAC, message.PCName, message.StetType);
                if (count > 0)
                {
                    Invoke(new MethodInvoker(delegate()
                    {
                        LoadStetInfoTZPZ();
                        MessageBox.Show("修改信息成功..");
                    }));
                }
            }
            else
            {

                string insertSql = "insert into StetInfo(StetName,SN,MAC,PCName,StetChineseName,Owner,FuncDescript,ReMark,RecordTime,StetType) select {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}";
                var count = Mediator.sqliteHelper.ExecuteNonQuery(insertSql, message.StetName, message.SN, message.MAC, message.PCName, message.StetChineseName, message.Owner, message.FuncDescript, message.ReMark, message.RecordTime.ToString("yyyy-MM-dd HH:mm:ss"), message.StetType);
                if (count > 0)
                {
                    Invoke(new MethodInvoker(delegate()
                    {
                        LoadStetInfoTZPZ();
                        MessageBox.Show("新增信息成功..");
                    }));

                }

            }

        }

        private void btnTZPZ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cbBoxTZPZ.Text))
            {
                MessageBox.Show("请选择一个听诊器...");
                return;
            }
            var formStetInfo = new FrmStetInfo()
            {
                StetName = cbBoxTZPZ.Text
            };
            formStetInfo.StartPosition = FormStartPosition.CenterParent;
            if (DialogResult.OK == formStetInfo.ShowDialog())
            {

                StetInfoCode stetInfoCode = new StetInfoCode()
                {
                    StetName = formStetInfo.StetName,
                    StetChineseName = formStetInfo.StetChineseName,
                    SN = Setting.authorizationInfo.AuthorizationNum,
                    PCName = CommonUtil.GetMachineName(),
                    MAC = Setting.authorizationInfo.MachineCode,
                    Owner = formStetInfo.StetOwner,
                    FuncDescript = formStetInfo.StetFuncDescript,
                    ReMark = formStetInfo.StetRemark,
                    StetType = formStetInfo.StetType
                };
                HandleMessage(stetInfoCode);
                if (Setting.isConnected)
                {
                    var code = Newtonsoft.Json.JsonConvert.SerializeObject(stetInfoCode);
                    using (OperationContextScope scope = new OperationContextScope(Mediator.remoteService.InnerChannel))
                    {
                        MessageHeader header = MessageHeader.CreateHeader("SN", "http://tempuri.org", Setting.authorizationInfo.AuthorizationNum);
                        OperationContext.Current.OutgoingMessageHeaders.Add(header);
                        header = MessageHeader.CreateHeader("MAC", "http://tempuri.org", Setting.authorizationInfo.MachineCode);
                        OperationContext.Current.OutgoingMessageHeaders.Add(header);
                        if (Mediator.remoteService.UpdateStetInfo(code))
                        {
                            Mediator.ShowMsg("新增听诊器 " + formStetInfo.StetName + " 信息，并上传服务器成功...");
                            Mediator.WriteLog(this.Name, "新增听诊器 " + formStetInfo.StetName + " 信息成功...,调用的后台方法是UpdateStetInfo");
                            return;
                        }
                        Mediator.WriteLog(this.Name, "新增听诊器 " + formStetInfo.StetName + " 信息失败...");
                        Mediator.ShowMsg("新增听诊器 " + formStetInfo.StetName + " 信息，并上传服务器失败...,调用的后台方法是UpdateStetInfo");
                    }
                }
            }
        }
    }
   
}
