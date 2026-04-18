# Unity Ohex

Unity에서 육각형 격자 좌표를 다루기 위한 패키지입니다.

## 설치

`Packages/manifest.json`의 `dependencies`에 다음 항목을 추가합니다.

```json
{
  "dependencies": {
    "com.oojjrs.ohex": "https://github.com/oojjrs/unity_ohex.git?path=/Packages/src#1.1.0"
  }
}
```

또는 Unity Package Manager의 `Add package from git URL...`에 같은 주소를 넣어 설치할 수 있습니다.

## 제공 기능

- `Hex` 구조체 기반 축 좌표(`Q`, `R`, `S`) 표현
- Pointy Topped, Flat Topped 형태 지원
- 월드 좌표와 육각 좌표 간 변환
- 이웃 타일, 대각선 타일, 오프셋 좌표 변환 유틸리티 제공

## 사용 예시

```csharp
using UnityEngine;

public class HexExample : MonoBehaviour
{
    void Start()
    {
        var hex = new Hex(2, 1, 1f, Hex.FormEnum.PointyTopped);
        Vector3 world = hex.ToWorld3D();

        var parsed = new Hex(world, 1f, Hex.FormEnum.PointyTopped);
        Debug.Log($"{parsed.Q}, {parsed.R}, {parsed.S}");
    }
}
```

## 패키지 구조

실제 Unity 패키지 루트는 `Packages/src`입니다.

- [패키지 문서](./Packages/src/README.md)
- [패키지 메타데이터](./Packages/src/package.json)