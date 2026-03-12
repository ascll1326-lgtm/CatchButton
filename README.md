# 2주차 과제: 버튼 잡기 게임
-이름: 안성철 (25017049)
-핵심기능: 커서를 피하는 버튼, 클리어 축하메세지 출력
## 실행 화면
![20260312_163714](https://github.com/user-attachments/assets/ee8f98d9-945f-4c7d-8aa9-504c7d6395b0)
![20260312_165814](https://github.com/user-attachments/assets/e32d3d41-bb43-49be-97eb-5cc300664017)

## 구현 시 어려웠던 점
- 버튼이 화면 밖으로 나가지 않게 하기 위해서
- int maxX = this.ClientSize.Width;
int maxY = this.ClientSize.Height; 를
int maxX = this.ClientSize.Width - t_button.Width;
int maxY = this.ClientSize.Height - t_button.Height;로 바꿀 필요가 있었다.

- 버튼을 클릭했을 때 축하메세지를 출력하기 위한 코드를 ai의 도움을 받아 추가했다.
코드는 다음과 같다 MessageBox.Show("축하합니다~~!", "omedeto");
 MessageBox.Show("메세지", "제목"); 형식이다.

