# [ing] 나만의 게임 만들어보기 (조형승)

---
게임 장르 : 2D 로그라이크(인줄 알았지만 사실 버튼을 찾고 눌러서 탈출하는 게임) <br>
해상도 : 1920 * 1080 <br>

플레이 방법 :
  - 이동 : w, a, s, d, 또는 방향키(↑, ↓, ←, →)
  - 공격 : space 바 또는 마우스 좌클릭

---
### 과제 제출을 하며(a.k.a. 회고)
이번 개인과제 목표는 곧 시작될 팀과제에서 진행할 로그라이크 게임을 먼저 만들면서 부족했던 부분들을 보완하는 것이었다.<br>
제일 큰 목표는 InputSystem 에 사용되는 delegate 를 이해하는 것이었다.<br>
결론부터 이야기하자면, 확실히 이전보다는 delegate 와 더욱 친해진 기분이다.<br>
delegate 를 이해하는 데에 너무 많은 시간을 쏟아버려서<br>
어떻게든 제출기한 내에 게임에 시작과 끝을 만들기 위해<br>
게임의 장르가 로그라이크에서 탈출게임으로 바뀌긴 했지만 정말 귀한 배움을 얻은 시간이라 생각한다.<br>
<br>
![image](https://github.com/chochozane/PersonalProject_MyGame/assets/130233619/82384cbf-d398-4658-a4ce-ad6c844c0aa8)
*꿈은 크게 갖자.jpg*

이것저것 구현해보고 싶었던 기능들이 정말 많았지만<br>
(e.g. 인벤토리, 아이템, 사운드, NPC 대화, 미니맵, etc)<br>
과제 개선시간을 잘 활용해서 팀과제를 진행할 때 꼭 도입해보고 싶다.

❗<br>
그리고 게임 플레이를 해보면 공격 애니메이션은 있지만 실제 공격 처리는 이루어지지 않는 것을 발견할 수 있다.<br>
플레이어 이동 처리 부분은 강의 내용을 참고하면서 최대한 이해하며 작성을 했지만<br>
데미지 피격 부분은 아직 많은 공부가 필요하다.<br>

여전히 어렵긴 하지만 그래도 재미를 느낄 수 있어 감사하다. :)

이번에도 여러 과제를 진행해오면서 받았던 피드백을 바탕으로 신경써서 체크한 부분들은 다음과 같다.
- git commit 자주하기, commit 내용을 명확하고 직관적으로 작성하기
- 사용하지 않는 이벤트 함수와 using 문들은 지워주기
- 유니티 상에서 폴더링 챙기기(e.g. Scripts 폴더 안에 여러 하위 폴더들을 만들어서 script 들 정리하기)


---
### 🐾To improve : 
- 플레이어 움직임에 따라 들고있는 무기의 Sprite 뿐만 아니라 위치도 좌우로 뒤집기
- 데미지 피격 구현
- 아이템
- 인벤토리
- NPC 제작
- 사운드
- 미니맵

---
### ✨Things i did :
- 필수요구사항
  - ✅ 인트로 씬 구성
    - UI 구성 / 시작버튼 추가<br>
      ![image](https://github.com/chochozane/PersonalProject_MyGame/assets/130233619/f0f64fb7-3d1d-44b4-9d40-048ed744ca92)

  - ✅ 자유 게임 만들기
    - 전환 된 씬에서는 본인이 만들어보고 싶은 게임을 시작<br>
      ![image](https://github.com/chochozane/PersonalProject_MyGame/assets/130233619/f6a36b00-3691-44d7-a163-a1a88f0db2fc)
      - Player 의 움직임은 InputSystem 활용
      - Player 와 Enemy(Slime) 애니메이션 구현
      - 카메라가 Player 를 따라가도록 하는 기능은 Cinemachine 활용
      - 특정 위치에서 Teleport 기능 구현(사다리)<br>
        


- 선택요구사항
  - 오브젝트 폴링
  - ✅ Instantiate 로 오브젝트 생성
  - ✅ InputAction 사용
  - 스크립트로 버튼에 이벤트 추가
  - ✅ delegate 사용
  - raycast
  - generic 을 이용한 싱글톤
  - FSM
  - Dictionary 활용
  - Queue, Stack 활용

---
### 📌TO-DOs :
- ⬜ ❗ 데미지 피격 구현

---

