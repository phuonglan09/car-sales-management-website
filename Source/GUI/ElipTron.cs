
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace GUI
{
    public class ElipTron : Component
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //tạo hình chữ nhật bo tròn
        private static extern IntPtr CreateRoundRectRgn
        (
            int Trai, int Tren, int Phai, int Duoi, int Rong, int Cao
        );
        private int radius = 39;     // lưu độ cong
        private Control contr; // lưu control

        //truy xuất hoặc gán giá trị cho độ cong
        public int CornerRadius
        {
            get { return radius; }
            set
            {
                radius = value;  //lưu giá trị được gán

                if (contr != null)
                {
                    // tạo mới
                    contr.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, contr.Width, contr.Height, radius, radius));
                }
            }
        }

        //truy xuất hoặc gán giá trị cho control
        public Control TargetControl
        {
            get { return contr; }
            set
            {
                contr = value;
                // Khi kích thước control thay đổi, tạo mới hình bo tròn
                contr.SizeChanged += (sender, eventArgs) => contr.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, contr.Width, contr.Height, radius, radius));
            }
        }

        private void InitializeComponent()
        {

        }
    }
}