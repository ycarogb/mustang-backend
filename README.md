# Mustang App
## Descrição do Projeto
API criada para  simplificar uma tela de escolha do modo de entrega de uma maneira mais dinâmica e atraente. Sendo, como principal objetivo aumentar a conversão de vendas nas opções de entrega.
O projeto foi desenvolvido durante o módulo 05 do Curso de Programação na Blue EdTech. O desafio foi proposto pelo Grupo Level, que possui o maior e-commerce de venda de pneus do Brasil, denominado Pneustore, que agora com dois novos modos de entrega lançados em 2021:

- Montagem Móvel
- Montagem Via Parceiro
- Entrega Em Casa

[![Generic badge](https://img.shields.io/badge/Version-1.0-<COLOR>.svg)](https://shields.io/)

## Estrutura da Aplicação

### A Aplicação segue um fluxo simples e direto, visando dar ao cliente mais agilidade ao processo de compra.

### O Fluxo acontece da seguinte forma:

- É carregado uma tela do carrinho de compras  já contendo um endpoint que retorna todos os produtos com o método GetAll();
- Em seguida o cliente insere o CEP de sua residência;
- Se houver serviço móvel disponível para o CEP, será carregado um carrossel mostrando os parceiros cadastrados aptos a atenderem ao cliente;
- O DropDown com o serviço móvel terá 3 opções de entrega, sendo o Serviço Móvel, a Retirada em um Parceiro e a Entrega em casa.
- No serviço móvel o Cliente poderá escolher um combo, logo em seguida aparece um card com a descrição do combo.
- Um calendário aparece para que o usuário possa escolher uma data para entrega.
- Logo em seguida o Cliente seleciona um perídodo e se tiver, um cupom de desconto.
- Então, para finalizar um resumo da compra é disponibilizado.
- Na entrega em casa o Cliente não tem a opção de escolher um Combo, então em seguida aparece o resumo da compra.
- Na opção de Retirada com o parceiro irá aparecer um  Carrossel com os parceiros existentes.
- Em seguida surge um card contendo opções de combo, sendo eles:  Apenas entrega em Centro de Montagem ,  Montagem + Balanceamento, e Cupom de  desconto, finalizando com  o resumo da compra.

# Informações Técnicas
O Back-End desta aplicação foi desenvolvido em linguagem C#, com o framework .NET Core 5.0. Os seguintes pacotes foram utilizados para o desenvolvimento da aplicação:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Identity.UI
- O Front-End da aplicação foi desenvolvido em linguagem Javascript, Reactjs, UI Lib e React-animated.

Para finalizar segue abaixo o link da Aplicação Para Melhores Avaliações:
https://mustangfrontapp.herokuapp.com/


# Autores
### Ycaro Batalha
<img style="border-radius: 80%;" src="https://i1.sndcdn.com/avatars-001002863491-80v8qp-t500x500.jpg" width="100px;" alt=""/>
<a href="https://www.linkedin.com/in/ycaro-gabriel-da-costa-batalha-2019" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a> 

### Leonardo Pereira
<img style = "border radius: 80%;" src = "https://media-exp1.licdn.com/dms/image/C4E03AQF3gkIPWId44w/profile-displayphoto-shrink_800_800/0/1634427027151?e=1640217600&v=beta&t=TLQ0SlmK5mKZjqDEfzzC9ahws7MmK9r9jQHsQtGAYQI" width ="100px;" alt = "" />
<a href="https://www.linkedin.com/in/leonardo-pereira-41353117a/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a>

### Marcos César Domingues
<img style = "border radius: 80%;" src = "https://avatars.githubusercontent.com/u/67762118?v=4" width ="100px;" alt = "" />
<a href="https://www.linkedin.com/in/marcos-domingues-bbb7b21b7" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a>

### Rosicleia Fürst
<img style = "border radius: 80%;" src = "https://media-exp1.licdn.com/dms/image/C4D03AQHYdL5Nzs-pSw/profile-displayphoto-shrink_200_200/0/1634436390550?e=1640217600&v=beta&t=r93PMuszmM0r_4cqAn62WOBFI1oJhFJDYQweIZx2vxM" width ="100px;" alt = "" />
<a href="https://www.linkedin.com/in/rosicleiafurst/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a>

### Thiago Leão
<img style = "border radius: 80%;" src = "https://media-exp1.licdn.com/dms/image/C4D03AQG3dTQ5jHJRRg/profile-displayphoto-shrink_800_800/0/1613065807294?e=1640217600&v=beta&t=UjTbp-8_LIak58jI4mYlHswx36okLae6A4GIl_wmUt4" width ="100px;" alt = "" />
<a href="https://www.linkedin.com/in/thiago-le%C3%A3o-62988784/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a>

