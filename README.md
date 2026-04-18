# Unity Ohex

Unity?먯꽌 ?↔컖??醫뚰몴? ?붾뱶 醫뚰몴瑜??ㅻ（湲??꾪븳 ?⑦궎吏?낅땲??

## ?ㅼ튂

`Packages/manifest.json`??`dependencies`???ㅼ쓬 ??ぉ??異붽??⑸땲??

```json
{
  "dependencies": {
    "com.oojjrs.ohex": "https://github.com/oojjrs/unity_ohex.git?path=/Packages/src#1.1.0"
  }
}
```

?⑦궎吏 留ㅻ땲???`Add package from git URL...`??媛숈? 二쇱냼瑜??ｌ뼱 ?ㅼ튂?대룄 ?⑸땲??

## ?ы븿 ?댁슜

- `Hex` 援ъ“泥대줈 異?醫뚰몴(`Q`, `R`, `S`) ?쒗쁽
- Pointy Topped, Flat Topped ?뺥깭 吏??- ?붾뱶 醫뚰몴? ?↔컖 醫뚰몴 蹂??- ?댁썐 ??? ?媛곸꽑 ??? 醫뚰몴 蹂???좏떥由ы떚 ?쒓났

## ?ъ슜 ?덉떆

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

## ?⑦궎吏 援ъ“

?ㅼ젣 Unity ?⑦궎吏 猷⑦듃??`Packages/src`?낅땲??

- [?⑦궎吏 臾몄꽌](./Packages/src/README.md)
- [?⑦궎吏 硫뷀??곗씠??(./Packages/src/package.json)
