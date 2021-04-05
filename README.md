# C_Dentist_VR_AR_
#8. 어린이용 치과의사 체험_VR_AR

- 시현 동영상(모바일, PC), 스크립트, .apk파일 첨부.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 1. 개발 계기

```
2020년 4학년 2학기 장기인턴으로 마지막 학기 진행.
VR(모바일) Unity로 2인 개발(충치 치료, 이물질 제거).
어린이들이 직접 손으로 움직이고 체험할 수 있는 것을 생각했다.
Cardboard를 끼고 몰입감을 높이며 마커를 통해 직접 움직임까지 더하면
실감나게 직접 체험할 수 있다는 생각으로 개발하게 되었다.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 2. 작품 소개

![image](https://user-images.githubusercontent.com/81169838/113530228-74486500-9600-11eb-8c24-b84609936477.png)

```
이 프로젝트는 크게 세가지 체험으로 나뉘어져 있다.
1. 충치 치료
2. 이 뽑기(미 완성)
3. 이물질 제거
각 체험 마다 치료하는 방법 및 도구가 변경됨.
```

## 3. 역할

```
치과의사 체험 모든 기획 및 구상, 스크립트 작성, 시현 동영상 편집 등.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 4. 구현한 것

- 플레이어 이동

![녹화_2021_04_05_11_21_35_238](https://user-images.githubusercontent.com/81169838/113530532-3b5cc000-9601-11eb-8426-c75873be856f.gif)

```
Cardboard를 끼고 시선을 밑으로 30˚를 바라보면 앞으로 이동.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 선택

![녹화_2021_04_05_11_36_06_355](https://user-images.githubusercontent.com/81169838/113531239-26812c00-9603-11eb-9469-c1715a3913cb.gif)

```
원하는 선택지를 바라보고 커서게이지가 다 차면 선택.
선택지에 따라 다른 체험을 할 수 있음.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 2D, VR, AR화면

![녹화_2021_04_05_16_27_01_977](https://user-images.githubusercontent.com/81169838/113549133-d5d1f900-962b-11eb-8f4c-5d952873e9d1.gif)

```
자유로운 화면 변경
EX) 2D -> VR
    VR -> VR + AR
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Modeling

![image](https://user-images.githubusercontent.com/81169838/113552661-6959f880-9631-11eb-9381-477690c86201.png)
![image](https://user-images.githubusercontent.com/81169838/113552520-344da600-9631-11eb-9734-c5ad82f55633.png)
![image](https://user-images.githubusercontent.com/81169838/113552619-56dfbf00-9631-11eb-9fff-2aaaca89ead8.png)

```
유료 Mouth에셋을 삼 -> Blender를 이용 -> 필요한 부위 등 분리를 시킴.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Pro Bulider

![image](https://user-images.githubusercontent.com/81169838/113558062-facd6880-9639-11eb-8b00-385343ac24d5.png)

```
Pro Builder 사용 -> 오브젝트를 오목 및 볼록, 늘림 -> 피 표현.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Etc.

```
Particle
Animation
Bgm
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 5. 게임

- 앱 실행 후 첫 화면

![녹화_2021_04_05_11_39_38_309](https://user-images.githubusercontent.com/81169838/113531390-a3140a80-9603-11eb-8ebd-b30f1f4502aa.gif)

```
2D 화면의 메인메뉴 -> 치과 선택(Touch) -> Cardboard 장착 -> VR모드 변경 -> 플레이.
※ 2D 화면의 메인메뉴 -> 오른쪽 하단의 X -> 어플 종료.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 환자 시점

![녹화_2021_04_05_11_52_12_322](https://user-images.githubusercontent.com/81169838/113532065-6d702100-9605-11eb-804b-d03550c36807.gif)

```
병원 -> 아리와 대화 -> 호빵 쌤 방으로 이동 -> 화면 Fade in.
※ 플레이어 이동의 설명과 기본 움직임을 통해 환자의 시점을 반영.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 의사 시점

![녹화_2021_04_05_11_57_50_241](https://user-images.githubusercontent.com/81169838/113532396-36e6d600-9606-11eb-9bbe-27d02de334cd.gif)

```
의사 시점 -> 환자와 의사의 대화 -> 3가지 중 체험하고 싶은 것 선택.
※ 환자는 아리, 아지, 상아 총 3명으로 랜덤으로 생성(대화 내용도 랜덤).
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- AR에 대하여

![녹화_2021_04_05_16_04_03_44](https://user-images.githubusercontent.com/81169838/113547330-a53c9000-9628-11eb-9267-f06a65f42928.gif)

```
3가지 선택지 중 모두 공통으로 나오는 씬.
간단한 AR에 대한 설명과 사용방법에 대해 설명함.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 충치 치료

![녹화_2021_04_05_16_06_27_28](https://user-images.githubusercontent.com/81169838/113548839-33b21100-962b-11eb-9657-b266e30bf0f2.gif)

```
충치 치료 씬 -> VR + AR화면(화면은 두개로 보이고 폰의 카메라로 마커를 인식할 수 있음).
-> 마커에 주의점, 간단한 플레이 설명.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Part 1(드릴)

![녹화_2021_04_05_16_22_26_79](https://user-images.githubusercontent.com/81169838/113549607-ac659d00-962c-11eb-864c-6d4f074060d9.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_16_31_09_32](https://user-images.githubusercontent.com/81169838/113549456-6c9eb580-962c-11eb-9d80-66002f95fc34.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![image](https://user-images.githubusercontent.com/81169838/113549980-4594b380-962d-11eb-9629-a9cd7613032d.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_16_43_23_894](https://user-images.githubusercontent.com/81169838/113550487-1763a380-962e-11eb-8703-c4e49f7dc030.gif)

```
충치에 드릴(끝부분)이 충돌함 -> 충치가 조금씩 사라짐.
모두 제거 -> Part 2(인레이)로 넘어감.
충치 : 총12개 3개씩 4묶음 -> 충치의 생성은 매번 1묶음이 랜덤으로 생생됨(랜덤 생성).
Animation : 4초간 충치 이동 -> 충치가 사라짐.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Part 2(인레이)

![녹화_2021_04_05_17_24_54_117](https://user-images.githubusercontent.com/81169838/113554193-e5edd680-9633-11eb-84af-a37a89bc5034.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_17_29_08_56](https://user-images.githubusercontent.com/81169838/113554556-74faee80-9634-11eb-87d3-285fca186623.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_17_30_06_372](https://user-images.githubusercontent.com/81169838/113554637-95c34400-9634-11eb-804d-7ba6722911b9.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_17_33_22_150](https://user-images.githubusercontent.com/81169838/113554937-0e2a0500-9635-11eb-82c8-060896b6a16c.gif)

```
충치에 인레이(끝부분)가 충돌함 -> 금 간 곳을 매꿈.
모두 제거 -> Part 2(인레이) Clear.
Clear 선택 -> 다른 체험할 수 있는 씬으로 이동.
Animation : 3초간 금간 곳이 사라짐 -> 금간 곳이 매꿔짐.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 이물질 제거

![녹화_2021_04_05_17_39_22_781](https://user-images.githubusercontent.com/81169838/113555455-ea1af380-9635-11eb-8ce6-615b45ebaddc.gif)

```
이물질 제거 씬 -> VR + AR화면(화면은 두개로 보이고 폰의 카메라로 마커를 인식할 수 있음).
-> 마커에 주의점, 간단한 플레이 설명.
```
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Part 1(긁기)

![녹화_2021_04_05_17_47_49_413](https://user-images.githubusercontent.com/81169838/113556199-171bd600-9637-11eb-80ca-37c6fc785312.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_17_51_20_877](https://user-images.githubusercontent.com/81169838/113556507-8e516a00-9637-11eb-8e7a-96d97921217d.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![image](https://user-images.githubusercontent.com/81169838/113556683-cc4e8e00-9637-11eb-84f6-14921f268c54.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_17_57_27_534](https://user-images.githubusercontent.com/81169838/113557081-6adaef00-9638-11eb-9632-65b5b892e3c4.gif)

```
치석에 긁개(끝부분)가 충돌함 -> 치석이 조금씩 사라짐.
모두 제거 -> Part 2(물)로 넘어감.
치석 : 총10개 5개씩 2묶음 -> 치석의 생성은 매번 1묶음이 랜덤으로 생생됨(랜덤 생성).
Animation : 4초간 치석이 이동 -> 치석이 사라짐.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- Part 2(물)

![녹화_2021_04_05_18_05_04_422](https://user-images.githubusercontent.com/81169838/113557757-7f6bb700-9639-11eb-94b4-ef266cde7414.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_18_06_52_574](https://user-images.githubusercontent.com/81169838/113557923-be017180-9639-11eb-89d0-f4799d50c239.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_18_07_28_98](https://user-images.githubusercontent.com/81169838/113557962-cf4a7e00-9639-11eb-819a-75b02ba3542b.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_04_05_18_10_33_328](https://user-images.githubusercontent.com/81169838/113558249-44b64e80-963a-11eb-9b57-2b6fc2188012.gif)

```
피에 물 뿌리개(끝부분)가 충돌함 -> 피가 사라짐.
모두 제거 -> Part 2(물) Clear.
Clear 선택 -> 다른 체험할 수 있는 씬으로 이동.
Animation : 4초간 피가 이동 -> 피가 사라짐.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 6. 아쉬웠던 점

```
제일 아쉬웠던 점은 이 프로젝트는 바로 미완성이라는 것이다.
나는 치과의사 체험 프로젝트의 기획 및 구상 등 모든 것을 다 계획했고
내가 맡았던 충치 치료와 이물질 제거 파트는 모두 끝냈다.
파트너가 이 뽑기 파트를 완성하지 못 해 비록 미완성으로 끝났지만
만약 내가 이 뽑기 파트를 만들었다면 대강 이런 구도였을 것이다.
이를 뽑는 펜치로 썩은 이와 충돌했을 때 Animation을 활용해
이가 흔들리는 효과를 주고 뽑고 난 자리에 크라운 시술을 구현해
빈 곳에 이를 채워 넣는 방식으로 했을 것 같다.
또 AR의 단점인 인식 문제 등의 이유 때문에
처음에 하려했던 3D Object의 활용은 실패했다.
3D Object란 타겟 Type중 하나의 방법이다.
3D 물건의 특징점을 잡아 마커로 인식하는 것이다.
하지만 3D Object도 내가 손으로 잡고 해야하는 방식이라
인식률이 떨어지며 물체의 자유자제로 움직이는 것이 불편했다.
결국 다시 돌아와 이미지 타겟을 이용해 플레이 하는 것으로 했고
나중에 기회가 되면 3D Ojbect를 이용해 더 실감나게 개발하고 싶다.
```

- 3D Object Recognition

![image](https://user-images.githubusercontent.com/81169838/113559993-3fa6ce80-963d-11eb-965b-feede2d9cc54.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![image](https://user-images.githubusercontent.com/81169838/113559933-27cf4a80-963d-11eb-80df-9a7964a381cd.png)

```
스캔용 마커 용지 -> 오른쪽 상단에 3D Object를 올려놓는다.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

![image](https://user-images.githubusercontent.com/81169838/113560132-75e44e00-963d-11eb-8f16-a5fde39a1a69.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![image](https://user-images.githubusercontent.com/81169838/113560249-a6c48300-963d-11eb-916c-695e56243a3e.png)

```
Vuforia Ojbect Scanner 어플 사용 -> 동영상 촬영(다 방면 촬영) -> 스캔 결과 화면.
스캔 데이터를 공유 -> 3D Ojbect를 선택(.od 파일) -> 이미지 타겟처럼 사용.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 7. 느낀 점

```
졸업하기 전 마지막학기이자 마지막 프로젝트였다.
아쉬웠던 점에서 적었듯이 미완성 프로젝트라 아쉬웠지만 이 프로젝트는 VR + AR을 섞어
여태 개발했던 2D, PC, VR, AR 단일 프로젝트와 달리 퓨전형 프로젝트라는 것이다.
기능이 섞이고 추가된 만큼 많은 정보들과 고난과 역경 및 시간들이 걸렸지만
결국에는 퓨전에 성공했고 성공한 뒤 그 희열은 여태느껴본 적 없는 것이였다.
사람이 게임이든 공부든 운동이든 자신이 세운 계획과 목표를 둘 다 잡는다면 얻는 
희열이 바로 이런 것이 아닐까 생각한다.
또 포트폴리오를 작성하면서 내가 개발한 프로젝트를 순서대로 쭉 한 번 살펴보고
각 프로젝트 마다 힘들고 좋았던 기억들, 구현된 기술 등 다시 볼 수 있어서 좋았고
내 스스로가 많이 발전했고 대견하다고 생각한다.
물론 지금의 나는 이 분야에서 최고, 끝판왕이라는 타이틀에 명함 하나 못 내겠지만
앞으로 내 직업이 되고 꿈을 실현하는 것을 생각하면 여태 했던 것들보다
더욱 많이 공부를 하고 개발 하고 실패도 하고 여러가지의 경험들을 거쳐야
자랑스럽고 존경을 받을 수 있을 사람이 될테니까 앞으로도 연구해야 할 것이다.
앞으로의 개발하는 프로젝트와 실패한 프로젝트 등 모두 업데이트 할 생각이며
5년 10년 20년 뒤에는 더욱더 발전한 나를 보며 흐뭇하게 웃을 생각으로
나는 앞으로 더 열심히 배우고 공부할 생각이다.
```

