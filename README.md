# 2022-303-Upwards!

### Equipe:
<p>Enzo Bigodeiro Bernardes, Jhulya Cristina Silva Gonçalves, Luan Vitor Carvalho Valadares e Lucas Gomes Rodrigues</p>

<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/Title.png"</p>

## Sobre o Jogo

"Upwards!" é um jogo de plataforma em que o jogador ajuda pequenos animais a alcançar o topo de uma árvore, com cada um deles possuindo a própria árvore e motivação para chegar ao topo! A principal questão desenvolvida no projeto é a sua acessibilidade para pessoas com daltonismo, implementada não como uma opção no menu de configurações, mas sim na própria paleta de cores do jogo inteiro, que utiliza cores baseadas na maneira como pessoas com esse tipo de deficiência enxergam o mundo. Além disso, o jogo conta com controles simples e um sistema de pontuação que incentiva a competitividade entre todos os tipos de pessoas.

## Personagens e Mundo
Todos nós temos objetivos que desejamos conquistar na vida, por mais simples que sejam. Para representar isso, cada um dos nossos três protagonistas possui a própria árvore a ser escalada. Cada um deles possui uma história própria a ser contada: 

- O Esquilo Escudeiro é um esquilo vermelho que vive em um grande pinheiro com sua família, mas há um problema. O inverno está chegando, e agora, ele precisa se apressar e coletar o máximo possível de comida pela árvore para alimentar seus filhos antes que o outono acabe.
- O Macaco Monge é um pequeno macaco-japonês que busca o esclarecimento divino. Ele treinou durante toda sua vida para esse momento, para finalmente conseguir escalar a cerejeira sagrada e alcançar o grande templo na copa da árvore. 
- A Arara Arqueira é uma pequena filhote de arara-azul-grande que acabou caindo de seu ninho por acidente. Ela ainda não é capaz de voar perfeitamente, mas as suas flechas a ajudarão a retornar para sua família no topo do ipê-amarelo.

<p><img width="150px" src="https://github.com/TP-Coltec-UFMG/2022-303-Upwards/blob/main/Images/Monkey.png"></p>
<p><img width="150px" src="https://github.com/TP-Coltec-UFMG/2022-303-Upwards/blob/main/Images/Squirrel.png"></p>
<p><img width="150px" src="https://github.com/TP-Coltec-UFMG/2022-303-Upwards/blob/main/Images/Macaw.png"></p>
	
## Acessibilidade
Um dos fundamentos do projeto é que ele seja divertido para todos, portanto também deve ser primeiramente acessível a todos. "Upwards!" contará com opções de configuração que permitem pessoas com quase qualquer tipo de deficiência, como por exemplo:

### Acessibilidade para Deficiêntes Visuais
- Filtros de Daltonismo
	- "Upwards!" é um jogo pensado desde o início para possuir paletas de cores representando os três principais tipos de daltonismo: Protanopia, Deuteranopia e Tritanopia. Cada um desses tipos será implementado em uma das três fases do jogo, correspondentes a cada um dos três protagonistas escalando a própria árvore. Algumas concept art já estão sendo desenvolvidas, e logo abaixo temos um exemplo de como uma arte é vista por uma pessoa sem daltonismo e por pessoas com os três tipos de daltonismo aqui citados:

<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/Sprites.png"</p>

- Alto Contraste
	- De maneira semelhante aos filtros de daltonismo, o modo de alto contraste auxiliará os jogadores com baixa visão a identificar mais facilmente os principais elementos presentes na tela do jogo, os destacando com cores mais vivas e mais distintas entre si.

### Qualidade de Vida
Além dos controles simples que o jogo possui (apenas um botão com a função de fazer o personagem pular), "Upwards!" também contará com sistemas que melhoram a qualidade de vida do jogador. Um desses sistemas é o chamado "tempo do coiote", que se refere às famosas cenas de desenho animado em que um personagem corre em direção a um precipício porém permanece flutuando no ar por alguns segundos antes de realmente cair. Dentro do jogo, por exemplo, uma mecânica de pular pouco antes de realmente atingir o chão, consegue facilitar a vida do jogador e melhorar sua experiência mesmo sem ele perceber

## Primeiro Protótipo
Ao desenvolver a primeira versão do jogo, nós não havíamos nem sequer definido um nome ainda. Porém durante essa etapa nós já possuíamos a versão inicial do menu, já pensada com as questões de acessibilidade e uma concept art da tela de fundo. E ao clicar em "jogar" no menu, o jogador é direcionado a uma tela de jogo com um cubo se movendo de um lado para o outro na tela, que podia também pular ao pressionar a barra de espaço. Esse foi o início da jogabilidade de "Upwards!".

<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/menu1.png"</p>

### Menu de Opções
O menu de opções ou de configurações do nosso jogo conta com quatro abas principais: a aba de gráficos que ajusta a resolução da tela, a aba de sons que cuida do volume dos sons do jogo, a aba de jogabilidade responsável pela definição dos controles e por fim a aba de acessibilidade que implementa as configurações relacionadas à acessibilidade como o filtro de daltonismo e o modo de alto contraste.
	
<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/menu2.png"></p>

## Versão Atual 
No projeto atual, as artes do menu do jogo foram atualizadas, contando agora também com um protótipo de logo com o nome "Upwards!". A jogabilidade foi incrementada com a mecânica de pulo para os personagens e os mapas de cada fase também começaram a ser desenvolvidos. De certa forma essa versão já está até mesmo jogável, como mostra o gif logo abaixo: 

<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/Jogo.gif"></p>

## Referências
- Artigo informativo sobre o que é o daltonismo e seus diferentes tipos:
	- https://bcc.ime.usp.br/tccs/2014/atakata/docs/Daltonismo_v3.pdf
- Site com função de aplicar filtros de daltonismo em imagens:
	- https://www.color-blindness.com/coblis-color-blindness-simulator/
