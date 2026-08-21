# UnityOhex

Unity에서 Pointy Topped 또는 Flat Topped 육각 격자의 축 좌표와 월드 좌표를 변환하는 유틸리티 패키지입니다.

## 설치

Unity Package Manager의 `Add package from git URL...`에 다음 주소를 입력합니다.

```text
https://github.com/oojjrs/unity_ohex.git?path=/Packages/src
```

## 구성

| 구성 요소 | 종류 | 용도 |
| --- | --- | --- |
| `Hex` | 구조체 | `Q`, `R`, `S` 축 좌표와 크기·형태 보관 |
| `Hex.FormEnum` | 열거형 | Pointy Topped와 Flat Topped 형태 선택 |
| `Neighbors`, `Diagonals` | 프로퍼티 | 인접 좌표와 대각선 좌표 열거 |
| `AsDoubleOffsetCoordinate`, `AsEvenOffsetCoordinate`, `AsOddOffsetCoordinate` | 프로퍼티 | 축 좌표를 오프셋 좌표로 변환 |

## 사용

```csharp
var hex = new Hex(2, 1, 1f, Hex.FormEnum.PointyTopped);
Vector3 world = hex.ToWorld3D();
var restored = new Hex(world, 1f, Hex.FormEnum.PointyTopped);
```

## 제약

- Unity `6000.0` 이상을 사용합니다.
- `ToWorld3D()`와 `Hex(Vector3, ...)`는 Unity의 XZ 평면을 육각 격자 평면으로 사용합니다.

## 문서

- [패키지 상세 문서](Packages/src/README.md)
