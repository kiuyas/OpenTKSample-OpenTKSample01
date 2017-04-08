using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenTKSample01
{
    public partial class Form1 : Form
    {
        #region 定数フィールド

        /// <summary>Fovy以外の各パラメータに指定できる最大値</summary>
        private const float MAX = 65;

        /// <summary>Fovy以外の各パラメータの精度</summary>
        private const float TICK = 0.01F;

        /// <summary>Fovy以外の各パラメータのトラックバーの最大値</summary>
        private const float TRACKBAR_MAX = MAX * (1 / TICK);

        #endregion

        #region フィールド

        /// <summary>目の位置X座標</summary>
        private float eyeX = 0;

        /// <summary>目の位置Y座標</summary>
        private float eyeY = 0;

        /// <summary>目の位置X座標</summary>
        private float eyeZ = 0;

        /// <summary>注視点位置X座標</summary>
        private float targetX = 0;

        /// <summary>注視点位置Y座標</summary>
        private float targetY = 0;

        /// <summary>注視点位置Z座標</summary>
        private float targetZ = 0;

        /// <summary>目の向きX座標</summary>
        private float upX = 0;

        /// <summary>目の向きY座標</summary>
        private float upY = 0;

        /// <summary>目の向きZ座標</summary>
        private float upZ = 0;

        /// <summary>フォビー(視野角)</summary>
        private int fovy = 0;

        /// <summary>トラックバーオブジェクト群</summary>
        private TrackBar[] trackbars;

        /// <summary>値表示ラベルオブジェクト群</summary>
        private Label[] labels;

        #endregion

        #region 初期処理

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        private void Initialize()
        {
            trackbars = new TrackBar[] { trbEyeX, trbEyeY, trbEyeZ,
                trbTargetX, trbTargetY, trbTargetZ, trbUpX, trbUpY, trbUpZ, trbFovy };
            labels = new Label[] { lblEyeX, lblEyeY, lblEyeZ,
                lblTargetX, lblTargetY, lblTargetZ, lblUpX, lblUpY, lblUpZ, lblFovy };

            for(int i = 0; i < trackbars.Length - 1; i++)
            {
                trackbars[i].Minimum = -(int)TRACKBAR_MAX;
                trackbars[i].Maximum = (int)TRACKBAR_MAX;
            }

            ResetParameters();
            SetTrackBars();
            ShowParameters();
        }

        /// <summary>
        /// パラメータの初期化
        /// </summary>
        private void ResetParameters()
        {
            eyeX = 0;
            eyeY = 0;
            eyeZ = 5;
            targetX = 0;
            targetY = 0;
            targetZ = 0;
            upX = 0;
            upY = 1;
            upZ = 0;
            fovy = 45;
        }

        #endregion

        #region 描画処理

        /// <summary>
        /// 描画処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GLControl canvas = sender as GLControl;

            // 初期化
            InitFor3D(canvas.Width, canvas.Height);

            // 平面を描く
            DrawSurface();

            // 描画結果を反映させる
            canvas.SwapBuffers();
        }

        /// <summary>
        /// 三次元描画用に初期化する
        /// </summary>
        /// <param name="width">描画領域幅</param>
        /// <param name="height">描画領域高さ</param>
        private void InitFor3D(float width, float height)
        {
            // クリア
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // ビューポートの設定
            GL.Viewport(0, 0, (int)width, (int)height);

            // 視点の設定
            Matrix4 modelView = Matrix4.LookAt(eyeX, eyeY, eyeZ, targetX, targetY, targetZ, upX, upY, upZ);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);

            // 射影の設定
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(Deg2Rad(fovy), width / height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

            // ※実際には MathHelper.PiOver4 (45度) などをFovyとして指定することが多いみたいです。
            // ※aspect比の計算について、heightが0でないことを保証する必要があります。
        }

        /// <summary>
        /// 度数をラジアンに変換する
        /// </summary>
        /// <param name="degree">度数値</param>
        /// <returns>ラジアン値</returns>
        private float Deg2Rad(int degree)
        {
            return (float)(degree * Math.PI / 180);
        }

        /// <summary>
        /// 平面を描く
        /// </summary>
        private void DrawSurface()
        {
            GL.Color3(Color.Lime);
            GL.Begin(PrimitiveType.Lines);

            for (float i = -1; i <= 1.1; i += 0.1F)
            {
                GL.Vertex3(-1, i, 0);
                GL.Vertex3(1, i, 0);

                GL.Vertex3(i, -1, 0);
                GL.Vertex3(i, 1, 0);
            }

            GL.End();

            GL.Begin(PrimitiveType.TriangleFan);

            GL.Vertex3(0, 0.95, 0);
            GL.Vertex3(-0.05, 0.85, 0);
            GL.Vertex3(0.05, 0.85, 0);

            GL.End();
        }

        #endregion

        #region イベント処理

        /// <summary>
        /// トラックバースクロール時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            eyeX = trbEyeX.Value * TICK;
            eyeY = trbEyeY.Value * TICK;
            eyeZ = trbEyeZ.Value * TICK;
            targetX = trbTargetX.Value * TICK;
            targetY = trbTargetY.Value * TICK;
            targetZ = trbTargetZ.Value * TICK;
            upX = trbUpX.Value * TICK;
            upY = trbUpY.Value * TICK;
            upZ = trbUpZ.Value * TICK;
            fovy = trbFovy.Value;

            if (chkInterlock.Checked)
            {
                if (sender == trbEyeX || sender == trbEyeY)
                {
                    targetX = eyeX;
                    targetY = eyeY;
                }
                else if (sender == trbTargetX || sender == trbTargetY)
                {
                    eyeX = targetX;
                    eyeY = targetY;
                }
            }

            ShowParameters();
            glControl1.Invalidate();
        }

        /// <summary>
        /// トラックバーに値を設定する
        /// </summary>
        private void SetTrackBars()
        {
            float[] values = { eyeX, eyeY, eyeZ, targetX, targetY, targetZ, upX, upY, upZ, fovy };

            for(int i = 0; i < trackbars.Length; i++)
            {
                trackbars[i].Scroll -= new EventHandler(trackBar_Scroll);
                if (i < trackbars.Length - 1)
                {
                    trackbars[i].Value = (int)(values[i] / TICK);
                }
                else
                {
                    trackbars[i].Value = (int)(values[i]);
                }
                trackbars[i].Scroll += new EventHandler(trackBar_Scroll);
            }
        }

        /// <summary>
        /// パラメータの値をラベルに表示する
        /// </summary>
        private void ShowParameters()
        {
            float[] values = { eyeX, eyeY, eyeZ, targetX, targetY, targetZ, upX, upY, upZ, fovy };

            for (int i = 0; i < labels.Length; i++)
            {
                if (i < trackbars.Length - 1)
                {
                    labels[i].Text = values[i].ToString("F2");
                }
                else
                {
                    labels[i].Text = values[i].ToString();
                }
            }
        }

        /// <summary>
        /// リセットボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetParameters();
            SetTrackBars();
            ShowParameters();
            glControl1.Invalidate();
        }

        #endregion
    }
}
