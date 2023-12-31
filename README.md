# CATch BALL
## 4주차 팀 과제 벽돌 게임 

## ⏰개발기간
- 기획 기간 :: 23.11.30 게임 기획 및 팀원 역할 분담
- 1차 개발 기간 :: 23.12.01 팀원 별 기능 개발 완료 1차 main merge
- 2차 개발 기간 :: 23.12.04 1차 main merge 바탕으로 팀원 각자 Brunch로 분배하여 부가 기능 추가
- 3차 개발 기간 :: 23.12.05 2차 main merge 및 아트, 사운드 리소스 삽입 후, main brunch merge
- 4차 개발 기간 :: 23.12.06 3차 main merge START씬&END씬 추가 및 UI 삽입, 무한 모드 추가
- 5차 개발 기간 :: 23.12.07 최종 merge (JYbrunch) 오류 수정
  

## ✨게임 소개
### 🐱 CATch BALL
#### 📢 게임 소개
> 맛있는 밥이 얼어 붙었습니다! 
> <br> 공을 던져 얼음을 깨고 안에 갇힌 음식을 구해 맛있는 식사를 완성하세요. 냥냥!
#### 🏷게임 디자인
- 벽돌 = 얼음
- 패들 = 고양이(강아지)
- 아이템 = 반려동물의 밥 (츄르, 캔, 생선 등)
- 도트 일러스트
- 모바일 환경을 상정하여, 세로가 긴 화면 구성

## 📌주요 기능
### Start Scene
- 게임 시작 전, 패들 이미지를 고양이에서 강아지로 변경 가능.
- 기본 / 무한 모드 중 선택하여 게임 실행
### Main Scene
- 패들(고양이)를 마우스를 이용하여 좌우로 움직임
- 공이 튕기면서 벽돌(얼음)을 깸
- 점수는 벽돌(얼음)안의 아이템(밥)을 받았을 때 증가
- 공이 화면 아래, 바닥으로 떨어지면 기회 감소. (총 3번의 기회)
- 무한 모드 :: 벽돌(얼음)과 패들(고양이)가 닿을 시, 즉시 게임 종료 추가
- 무한 모드 :: 벽돌(얼음)이 한줄씩 생성되며, 아래로 이동

### End Scene
- 최종 점수에 따라 엔딩 이미지 변경
- 30점 이상이면 노멀 엔딩 이하면 새드엔딩
- 새로운 최고 점수 달성 시, New Best Score 마크 표시

### Ect
- 일시정지 버튼
- 시작 화면 / 새 게임 시작 버튼
  
## 🛠구현할 목록
- 레벨에 따라 패들 사이즈 조정
- 레벨에 따라 공 속도 증가
- 단단한 얼음 (n회 이상 볼과 충돌 시, 제거)
- 플레이 기능 향상 아이템 (볼 갯수 추가 등)

## 🔒 게임 버그 및 문제점
- 무한모드에서 벽돌생성과 함께 공이 부딪힐 경우 공이 소멸
- 공이 UI 영역까지 침범
- 공 발사전, 마우스를 과격하게 움직일시 패들 화면 이탈
- 객체지향 미숙

