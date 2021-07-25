# hololens-http-client-sample

## About

HTTPでJSONデータをHoloLensからPostしてローカルに保存したいという要望があったので、
そのための至極シンプルなサンプルプロジェクト。
[こちらのhttp鯖サンプル](https://github.com/drumath2237/simple-http-server-sample)と一緒にお使いください。

## Usage

まずは前述のhttp鯖をローカルで起動します。

`Assets/SampleScene`を開くと豆腐とボタンがあるので、シーンを再生してボタンを押下すると
ボタンのプレハブにアタッチされている`HttpSender`コンポーネントで指定されているURL（デフォルトでは`localhost:3000`）にサンプルデータをPOSTします。

## Additional info

まだHoloLensでは試していないですすみません。
たぶん問題ないはずですが。

## Contact

何かございましたら、[にー兄さんのTwitter](http://twitter.com/ninisan_drumath)まで
よろしくお願いいたします。
