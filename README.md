# 2주차 과제: 버튼 잡기 게임
-이름: 안성철 (25017049)
-핵심기능: 커서를 피하는 버튼
## 실행 화면
![20260312_163714](https://github.com/user-attachments/assets/ee8f98d9-945f-4c7d-8aa9-504c7d6395b0)

## 구현 시 어려웠던 점
- 버튼이 화면 밖으로 나가지 않게 하기 위해서
- int maxX = this.ClientSize.Width;
int maxY = this.ClientSize.Height; 를
int maxX = this.ClientSize.Width - t_button.Width;
int maxY = this.ClientSize.Height - t_button.Height;로 바꿀 필요가 있었다.
