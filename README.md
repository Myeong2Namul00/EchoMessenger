# (C# 코딩) 에코 메신저

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자가 입력한 메시지를 그대로 출력하는 간단한 콘솔 애플리케이션
- 사용한 플랫폼:
  - C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - TextBox: 사용자 입력을 받는 컨트롤
  - Button: 메시지를 출력하는 트리거 역할을 하는 컨트롤
  - Label: 출력된 메시지를 표시하는 컨트롤
  - CheckBox: 추가 기능을 활성화하는 옵션을 제공하는 컨트롤
- 사용한 기술과 구현한 기능:
  - Visual Studio의 Designer를 활용하여 UI 구성
  - string 클래스를 이용해 사용자 입력을 처리하고 출력
  - DateTime 클래스를 활용하여 메시지 출력 시각을 표시하는 기능 구현
  - CheckBox를 통해 메시지 출력 시각 표시 기능을 활성화/비활성화하는 기능 구현
  - list 클래스를 활용하여 사용자 입력 메시지를 저장하고, 이전 메시지를 출력하는 기능 구현
  - messageBox 클래스를 활용하여 사용자에게 알림 메시지를 표시하는 기능 구현
  - clientsize 속성을 활용하여 애플리케이션 창의 크기를 조절하는 기능 구현
  - 메소드로 코드를 구조화하여 유지보수성을 높이는 기능 구현

# 각 과제별 실행 화면

## 실행 화면 (과제1)
![과제1 실행화면](img/screenshot-1.png)

-과제내용
  - Label(표시), TextBox(입력), Button(전송), ListBox(대화창)를 적절히 배치합니다.
  - 전송 버튼클릭시 TextBox의 텍스트를ListBox의 항목(Items)으로 추가합니다.
  - 추가직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비합니다.

- 구현 내용과 기능 설명
  - designer를 활용하여 TextBox, Button, Label 컨트롤을 배치하여 UI 구성
  - label을 배치하여 Echo Messenger라는 제목을 표시
  - textbox를 배치하고 사용자가 입력한 메시지를 받도록 설정
  - button을 배치하고 ENTER 텍스트를 추가
  - listbox를 배치하고 사용자가 입력한 메시지를 대화창에 표시하도록 설정
  - ENTER 버튼 클릭 이벤트 핸들러를 구현하여 TextBox의 텍스트를 ListBox에 추가하고, TextBox를 비우는 기능 구현


## 실행 화면 (과제2)
- 스크린샷 추가 예정

