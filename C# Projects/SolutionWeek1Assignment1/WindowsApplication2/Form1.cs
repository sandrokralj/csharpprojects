using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private ManufacturingCompany mc;

        public Form1()
        {
            InitializeComponent();
            mc = new ManufacturingCompany("VDL assembling Mini Cooper");
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add(mc.ToString());
            lbInfo.Items.Add("");
            foreach (Machine m in mc.Machines)
            {
                lbInfo.Items.Add(m.ToString());
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = new Machine(tbMachineName.Text, Convert.ToInt32(tbTemp.Text), Convert.ToInt32(tbPressure.Text));
               
                if (mc.AddMachine(m))
                {
                    MessageBox.Show("Successfully added");
                    m.CriticalState += new Machine.CriticalStateHandler(showCritical);
                }
                else
                {
                    MessageBox.Show("We already have a machine with that name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in some numbers for temperature and pressure");
            }

        }

        private void btnSimulateTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetTemperature(Convert.ToInt32(tbTemp.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for temperature");
            }
        }

        private void btnSimulatePressure_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetPressure(Convert.ToInt32(tbPressure.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for pressure");
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            Machine m = mc.GetMachine(tbMachineName.Text);

            if (m != null)
            {
                if (btnLogging.Text == "Start logging")
                {
                    m.CriticalState += new Machine.CriticalStateHandler(logData);
                    btnLogging.Text = "Stop logging";
                }
                else
                {
                    m.CriticalState -= new Machine.CriticalStateHandler(logData);
                    btnLogging.Text = "Start logging";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Machine m in mc.Machines)
            {
                m.RemoveAllCriticalStateHandlers();
            }

            try
            {
                using (FileStream fs = new FileStream("saveFile.bin", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, mc);
                    MessageBox.Show("saved to file");
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Error writing file");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("saveFile.bin", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    mc = (ManufacturingCompany)bf.Deserialize(fs);
                    MessageBox.Show("loaded from file");
                }
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showCritical(Machine m, string reason)
        {
            string message = m.Name + ": " + reason;
            lbWarnings.Items.Add(message);
        }

        private void logData(Machine m, string reason)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("logfile.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now + " : " + m.Name + "\t : " + reason);
            }
            catch (IOException)
            {
                MessageBox.Show("IO error");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}