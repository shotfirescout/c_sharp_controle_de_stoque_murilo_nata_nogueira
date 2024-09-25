# c_sharp_controle_de_stoque_murilo_nata_nogueira

Esse é uma atividade que necessita de algumas etapas para que ela funcione corretamente

1- é necessário ter instalado o MySql, porque esse código necessita de um banco de dados para que ele funcione

2- Após fazer sua configuração, execute o commando dentro do bash

mysql -u <seu_usuario> -p < (caminho_para_seu_projeto)/criar_Database.sql

3- Depois é abrir o arquivo jsonconfig.json, localizado nas pastas bin/Debug do projeto e editar essa região

    "Server": "localhost",
    "Database": "estoque",
    "Uid": "<Coloque seu User id aqui, ou root>",
    "Password": "<Coloque_sua_senha_aqui>

altere o Uid para o uid do seu banco de dados, e o password para a senha do banco de dados atribuida
