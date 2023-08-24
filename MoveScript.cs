using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
public class Program
{
    // Cursor Cursor;
    //     [STAThread]
    //     static void Main()
    //     {
    //         Application.EnableVisualStyles();
    //         Application.SetCompatibleTextRenderingDefault(false);
    //         Application.Run(new Form1());
    //     }
    //     public void MoveCursor()
    //     {
    //         this.Cursor = new Cursor(Cursor.Current.Handle);
    //         Cursor.Position = new Point(Cursor.Position.X - 150, Cursor.Position.Y - 150);
    //     }

    public static void Main() {
        Cursor Cursor;
        int move = 0;
        Point pt;
        while(true) {
            if (move == 1000) {
                move = 0;
            }
            pt = new Point(move, 768);
            Thread.Sleep(5000);
            Cursor.Position = pt;
            move++;
        }
    }
}

// public partial class EvoleToPokemon : Form
// {
//     public EvoleToPokemon()
//     {
//         InitializeComponent();
//     }
//     private void EvoleToPokemon_Load(object sender, EventArgs e)
//     {
//         var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
//         Top = _point.Y;
//         Left = MainForm.Instance.Location.X + MainForm.Instance.Width - Width;
//     }
// }