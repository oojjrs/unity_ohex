# com.oojjrs.ohex

`com.oojjrs.ohex`는 Unity용 육각형 좌표 유틸리티 패키지입니다.

## 주요 기능

- `Hex` 구조체 기반 축 좌표 표현
- Pointy Topped, Flat Topped 육각형 지원
- `Vector2`, `Vector3` 기준 좌표 변환
- 이웃 타일과 대각선 타일 열거
- Offset 좌표 변환 지원

## 기본 사용

```csharp
using UnityEngine;

public class HexSample : MonoBehaviour
{
    void Start()
    {
        var origin = new Hex(0, 0, 1f, Hex.FormEnum.FlatTopped);

        foreach (var neighbor in origin.Neighbors)
            Debug.Log(neighbor);

        var world = origin.ToWorld3D();
        var fromWorld = new Hex(world, 1f, Hex.FormEnum.FlatTopped);
        Debug.Log(fromWorld);
    }
}
```

## 좌표 변환

- `ToWorld2D()`는 `Vector2` 월드 좌표를 반환합니다.
- `ToWorld3D(float y = 0)`는 Unity `XZ` 평면 기준 `Vector3`를 반환합니다.
- `new Hex(Vector2 point, float size, Hex.FormEnum form)`으로 월드 좌표에서 육각 좌표를 계산할 수 있습니다.
- `AsDoubleOffsetCoordinate`, `AsEvenOffsetCoordinate`, `AsOddOffsetCoordinate`로 오프셋 좌표를 얻을 수 있습니다.

## 설치 주소

```text
https://github.com/oojjrs/unity_ohex.git?path=/Packages/src#1.1.0
```