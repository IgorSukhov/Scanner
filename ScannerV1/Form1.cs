using System;
using System.Windows.Forms;


namespace ScannerV1
{
    public partial class Form1 : Form
    {
        Scanner scanner;
        bool isGoingToClose = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Scanner_InitDone(object sender, EventArgs e)
        {
            Console.WriteLine("Init done!");
        }

        private void Scanner_MoveToCoordinatesDone(object sender, EventArgs e)
        {
            Console.WriteLine("Move to coordinates done!");
        }

        private void Scanner_CalibrationDone(object sender, EventArgs e)
        {
            Console.WriteLine("Calibration done!");
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            scanner = new Scanner();
            scanner.InitDone += Scanner_InitDone;
            scanner.StatusUpdated += Scanner_StatusUpdated;
            scanner.CalibrationDone += Scanner_CalibrationDone;
            scanner.MoveToCoordinatesDone += Scanner_MoveToCoordinatesDone;

            if (!scanner.Init("192.168.10.99"))
            {
                Console.WriteLine(scanner.LastError());
                MessageBox.Show("На данном компьютере необходимо установить сетевой адрес: 192.168.10.99");
                return;
            }
            buttonSetup.Enabled = false;
            buttonCalibration.Enabled = true;
            checkBoxAutoSetCoordinates.Enabled = true;
        }

        private void Scanner_StatusUpdated(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                if (!isGoingToClose)
                    Invoke(new EventHandler(Scanner_StatusUpdated), new object[] { sender, e });
            }
            else
            {
                labelCoordinates.Text = string.Format("cx: {0}, cy: {1}, cz: {2}, ca: {3}", scanner.CoordX / 200, scanner.CoordY / 200, scanner.CoordZ / 200, scanner.CoordA / 200);
                labelSpeeds.Text = string.Format("ux: {0}, uy: {1}, uz: {2}, ua: {3}", scanner.SpeedX, scanner.SpeedY, scanner.SpeedZ, scanner.SpeedA);
                labelLimits.Text = string.Format("lx: {0}, ly: {1}, lz: {2}, la: {3}", scanner.LimitX, scanner.LimitY, scanner.LimitZ, scanner.LimitA);
                if (!checkBoxAutoSetCoordinates.Checked)
                {
                    trackBarX.Value = scanner.CoordX;
                    trackBarY.Value = scanner.CoordY;
                    trackBarZ.Value = scanner.CoordZ;
                    trackBarA.Value = scanner.CoordA;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            scanner.Stop();
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            scanner.StartCalibration();
            buttonCalibration.Enabled = false;
            checkBoxAutoSetCoordinates.Checked = false;
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            textBoxMoveToCoordX.Text = (trackBarX.Value / (float)200).ToString();
            StartMovement();
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            textBoxMoveToCoordY.Text = (trackBarY.Value / (float)200).ToString();
            StartMovement();
        }

        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            textBoxMoveToCoordZ.Text = (trackBarZ.Value / (float)200).ToString();
            StartMovement();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            textBoxMoveToCoordA.Text = (trackBarA.Value / (float)96000 * 360).ToString();
            StartMovement();
        }

        private void StartMovement()
        {
            if (checkBoxAutoSetCoordinates.Checked)
            {
                scanner.MoveToCoordinates(
                    trackBarX.Value,
                    trackBarY.Value,
                    trackBarZ.Value,
                    trackBarA.Value);
            }
        }

        private void textBoxMoveToCoordX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float val;
                if (float.TryParse(textBoxMoveToCoordX.Text, out val))
                {
                    try
                    {
                        trackBarX.Value = (int)(val * 200);
                        StartMovement();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void textBoxMoveToCoordY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float val;
                if (float.TryParse(textBoxMoveToCoordY.Text, out val))
                {
                    try
                    {
                        trackBarY.Value = (int)(val * 200);
                        StartMovement();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void textBoxMoveToCoordZ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float val;
                if (float.TryParse(textBoxMoveToCoordZ.Text, out val))
                {
                    try
                    {
                        trackBarZ.Value = (int)(val * 200);
                        StartMovement();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void textBoxMoveToCoordA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float val;
                if (float.TryParse(textBoxMoveToCoordA.Text, out val))
                {
                    try
                    {
                        trackBarA.Value = (int)(val * 96000 / 360);
                        StartMovement();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void checkBoxAutoSetCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoSetCoordinates.Checked) StartMovement();
        }
    }
}
