# UnityEditorExtensionGetTransformsRange
## 範囲を指定して子オブジェクトの配列を取得するスクリプト

```c# : GameObjectExtensions.cs
public static Transform[] GetTransformsRange(this GameObject self, string from, string to, bool includeActive = false)
```

この関数はゲームオブジェクトの拡張メソッドとして用いることができる．

```c# 
GameObject armature;
Transform[] children = armature.GetTransformsRange(from: "Shoulder", to: "Hand"); 
```

例えば上記だと，armatureが持つ子オブジェクトの階層から，"Soulder"から"Hand"までの階層を取得することができる．

armatureの階層構造が，

```
Spine -> Shoulder -> Upper Arm -> Lower Arm -> Hand -> Fingers
```

だとすると，childrenは，

```
Shoulder -> Upper Arm -> Lower Arm -> Hand
```

となり，Shoulderより上の階層であるSpineやHandより下の階層であるFingerは配列に含まれない．

また，直接ゲームオブジェクトに追加・範囲指定することもできる．

下図のようにTest.csスクリプトを追加し，範囲となるゲームオブジェクトを指定・実行すると同様の結果が得られる．

![explain](https://user-images.githubusercontent.com/44863813/102711087-7ceb8880-42fa-11eb-9faf-541cf6993da7.png)




# Reference
- [コガネブログ](https://baba-s.hatenablog.com/)様より，
    - [指定したゲームオブジェクトから名前で子オブジェクトを検索する拡張メソッド](https://baba-s.hatenablog.com/entry/2014/08/01/101104)
    - [GetComponentsInChildrenで自分自身を含まないようにする拡張メソッド](https://baba-s.hatenablog.com/entry/2014/06/05/220224)

    を用いた．

