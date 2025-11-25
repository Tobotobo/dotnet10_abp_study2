# dotnet10_abp_study2


## 概要
* (前回) [dotnet10_abp_study1](https://github.com/Tobotobo/dotnet10_abp_study1)
* 前回は開発コンテナーが適当だったのでちゃんと構築
* まずは [ABP](https://github.com/abpframework/abp) をシンプルに試す

## 詳細

### 環境

```sh
$ grep VERSION= /etc/os-release 
VERSION="24.04.3 LTS (Noble Numbat)"
```

```sh
$ dotnet --version
10.0.100
```

```sh
$ node --version
v24.11.1
```
TODO: README.md に v18 or 20 って書かれてた 

```sh
$ pwsh --version
PowerShell 7.5.4
```

```sh
$ dotnet ef --version
Entity Framework Core .NET Command-line Tools
10.0.0
```

```sh
$ abp cli version
2.0.1
```

TODO: sqlite3 コマンドのインストール `sudo apt-get update && sudo apt-get install -y sqlite3`

### ソリューション作成

ABP CLI  
https://abp.io/docs/latest/cli  

```sh
abp new Example \
    --template app \
    --ui-framework no-ui \
    --database-provider ef \
    --dbms SQLite \
    --output-folder "./Example"
```
※ソースを表示した時にエラーになる場合は VSCode のウィンドウを再読込みするとだいたい直る

### ソリューションの初期化

```sh
(cd ./Example && pwsh ./etc/scripts/initialize-solution.ps1)
```

### フォルダ構成

![alt text](docs/images/1764082522687.png)

### 実行

```sh
(cd ./Example/src/Example.HttpApi.Host && dotnet run)
```

https://localhost:44384  

ID: `admin`  
PW: `1q2w3E*`  

![alt text](docs/images/1764083651617.png)

![alt text](docs/images/1764083819468.png)

![alt text](docs/images/1764083844105.png)

![alt text](docs/images/1764083867777.png)

![alt text](docs/images/1764083877698.png)

### Swagger

https://localhost:44384/swagger/index.html

![alt text](docs/images/1764083950954.png)

![alt text](docs/images/1764084033246.png)