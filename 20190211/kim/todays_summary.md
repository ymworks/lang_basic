# 本日の要約

## やったこと
1. 第4-1章
  * 制御フロー(if, for, foreach, while, do-while, switch)
    - for vs foreach : インデックスの使用
    - do-while : 一回は必ず実行する。
    - if vs switch : 可読性とパフォーマンス面を考慮して使う。

2. 環境
  * ローカル(Local or DEV)・ステージング(STG)・プロダクション（本番, PROD）
    - ステージングは、本番とほぼ同じ環境（CPUなどのスペックだけ多少低い）
    - STGにアクセスするためには、事前に定義したプロキシへのアクセスが必要。

3. リバースプロキシ(Reverse Proxy)
  - ストラクチャー： User(Chrome) > Reverse Proxy Server(nginx) > Web Server(Apache) > Application Server
  - ウェブサーバへの直接アクセスを防ぐ。目的は不正アクセスの遮断とシステムロード軽減。

## 宿題
1. 残りの４章を読んでくる。

## 来週の予告
 * 4-2, 4-3章
 * 来週からは、メモをvimでやりましょう。
