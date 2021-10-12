# Mustang Back End
## Descrição do Projeto
API criada para  simplificar uma tela de escolha do modo de entrega de uma maneira mais dinâmica e atraente. Sendo, como principal objetivo aumentar a conversão de vendas nas opções de entrega.
O projeto foi desenvolvido durante o módulo 05 do Curso de Programação na Blue EdTech. O desafio foi proposto pelo Grupo Level, que possui o maior e-commerce de venda de pneus do Brasil, denominado Pneustore, que agora com dois novos modos de entrega lançados em 2021:

- Montagem Móvel
- Montagem Via Parceiro


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
- 

