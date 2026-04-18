# com.oojjrs.ohex

`com.oojjrs.ohex`??Unity???↔컖??醫뚰몴 ?좏떥由ы떚 ?⑦궎吏?낅땲??

## 二쇱슂 湲곕뒫

- `Hex` 援ъ“泥?湲곕컲 異?醫뚰몴 ?쒗쁽
- Pointy Topped, Flat Topped ?↔컖??吏??- `Vector2`, `Vector3` 湲곗? 醫뚰몴 蹂??- ?댁썐 ??쇨낵 ?媛곸꽑 ????닿굅
- Offset 醫뚰몴 蹂??吏??
## 湲곕낯 ?ъ슜

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

## 醫뚰몴 蹂??
- `ToWorld2D()`??`Vector2` ?붾뱶 醫뚰몴瑜?諛섑솚?⑸땲??
- `ToWorld3D(float y = 0)`??Unity `XZ` ?됰㈃ 湲곗? `Vector3`瑜?諛섑솚?⑸땲??
- `new Hex(Vector2 point, float size, Hex.FormEnum form)`?쇰줈 ?붾뱶 醫뚰몴?먯꽌 ?↔컖 醫뚰몴瑜?怨꾩궛?????덉뒿?덈떎.
- `AsDoubleOffsetCoordinate`, `AsEvenOffsetCoordinate`, `AsOddOffsetCoordinate`濡??ㅽ봽??醫뚰몴瑜??살쓣 ???덉뒿?덈떎.

## ?ㅼ튂 二쇱냼

```text
https://github.com/oojjrs/unity_ohex.git?path=/Packages/src#1.1.0
```
