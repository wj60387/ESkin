using BDAuscultation.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BDAuscultation
{
    /// <summary>
    /// 听诊录音
    /// </summary>
    partial class FrmMain
    {
        void InitdgvTZLY()
        {
            this.btnTZLY.Click += btnTZLY_Click;
        }

        void btnTZLY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cbBoxTZLY.Text))
            {
                MessageBox.Show("请选择一个听诊器..");
                return;
            }
            var stetInfo = Setting.GetStetInfoByStetName(this.cbBoxTZLY.Text);
            var frmAudioRecord = new FrmAudioRecord()
            {
                PatientType = stetInfo.StetType,
                StetName = this.cbBoxTZLY.Text
            };
            frmAudioRecord.ShowDialog();
            LoadLocalPatientInfo();
        }
        void LoadStetInfoTZLYLocal()
        {
            cbBoxTZLY.Items.Clear();
            dgvTZLY_Down.Rows.Clear();
            foreach (var item in StethoscopeManager.StethoscopeList)
            {
                var stetInfo = Setting.GetStetInfoByStetName(item.Name);
                if (stetInfo == null || string.IsNullOrEmpty(stetInfo.StetChineseName))
                    cbBoxTZLY.Items.Add(item.Name);

                else
                {
                    dgvTZLY_Down.Rows.Add(stetInfo.StetName, stetInfo.PCName, Setting.GetPatientNameByType(stetInfo.StetType), stetInfo.StetChineseName, stetInfo.Owner, stetInfo.FuncDescript, stetInfo.ReMark, item.IsConnected ? "已连接" : "未连接");
                }
            }
            if (cbBoxTZLY.Items.Count > 0)
                cbBoxTZLY.SelectedIndex = 0;
        }

        void LoadLocalPatientInfo()
        {
            string sqlQuery = @"select * from PatientInfo where StetName={0} order by rowid desc";
            var dt = Mediator.sqliteHelper.ExecuteDatatable(sqlQuery, this.cbBoxTZLY.Text);
            dgvTZLY_Local.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvTZLY_Local.Rows.Add(dr[0],
                    Setting.GetPatientNameByType(int.Parse(dr["PatientType"] + ""))
                    , dr["PatientID"], dr["PatientName"],
                     dr["DocName"], dr["DocDiagnose"], dr["DocRemark"], dr["Flag"], dr["CreateTime"]);
            }

        }
        private void btnAuscultate_Click(object sender, EventArgs e)
        {

        }
    }

}
