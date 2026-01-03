# Space Shooting

Unityで制作した、Webブラウザで遊べる2Dシューティングゲームです。
PCでの動作に対応しています。

![Unity](https://img.shields.io/badge/Unity-2026.1-black.svg?style=flat&logo=unity)
![License](https://img.shields.io/badge/License-MIT-blue.svg)

## Demo

以下のリンクからブラウザ上でプレイできます（ダウンロード不要）。

**[Space Shooting (Unity Play)](https://play.unity.com/en/games/397092ad-aaf0-4b8b-b2e8-57f63c6e3207/webgl-builds)**

## Controls

**移動操作** : キーボードの `←` `↑` `↓` `→` キー
**UI操作** : クリック

## Features

* **HPバーの制御**
    * UI Canvasを使用し、ダメージに応じてゲージが減少します。
* **ゲームサイクル**
    * `GameManager` によるゲームステート管理。
    * 勝敗判定時のダメージ無効化処理とリザルト画面表示。
* **演出**
    * 衝突時のパーティクルエフェクト。
    * TextMeshProを使用した視認性の高いUIテキスト。

## Tech Stack

* **Engine:** Unity [6000.3.2f1]
* **Language:** C#
* **IDE:** Visual Studio Code
* **Deploy:** Unity Play (WebGL)

## Architecture

主なスクリプトの役割：

* `GameManager.cs`: ゲーム全体の進行管理、UI表示、リスタート。
* `PlayerController.cs`: プレイヤーの移動処理、一定時間ごとの弾丸発射処理。
* `EnemyController.cs`: プレイヤーの方向の弾丸、等間隔の拡散弾丸の発射処理。
* `BulletController.cs`: 弾丸の初速設定、対象との衝突判定処理。
* `LifeController.cs`: プレイヤーと敵HPの管理、死亡処理。
* `HPBarController.cs`: HPゲージの描画更新。
* `AutoDestroy.cs`: エフェクトの自動削除処理。

## How to Run Locally

1.  このリポジトリをクローンします。
    ```bash
    git clone https://github.com/e235733/space-shooting
    ```
2.  Unity Hubを開き、「Add (追加)」からクローンしたフォルダを選択します。
3.  プロジェクトを開き、`Scenes` フォルダ内のメインシーンを再生します。

## License

This project is licensed under the MIT License.