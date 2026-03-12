namespace CatchButton
{
    public partial class stage1 : Form
    {
        public stage1()
        {
            InitializeComponent();
        }

        int score = 0;
        
        private void t_button_MouseEnter(object sender, EventArgs e)
        {
     
            t_button.MaximumSize = new Size(348, 145); // 최대 크기
            // 1. 난수 생성기 준비
            Random rd = new Random();
            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width - t_button.Width;
            int maxY = this.ClientSize.Height - t_button.Height;
            // 3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치 할당 (새로운 Point 객체 생성)
            t_button.Location = new Point(nextX, nextY);
            if (score > 0){ 
                score -= 10;
                t_button.Size = new Size(t_button.Width + t_button.Width * 1/2, t_button.Height + t_button.Height * 1/2);
            }
            // 5. 시각적 피드백 (폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼 위치: ({nextX}, {nextY}), 점수: {score}";
            
        }

        private void t_button_Click(object sender, EventArgs e)
        {
            score += 100;
            MessageBox.Show("축하합니다~~!", "omedeto");
            t_button.Size = new Size(t_button.Width * 2/3, t_button.Height * 2/3);
        }
    }
}
