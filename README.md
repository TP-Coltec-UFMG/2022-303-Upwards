# 2022-303-NomeADefinir

### Equipe:
<p>Enzo Bigodeiro Bernardes, Jhulyya Cristina Silva Gonçalves, Luan Vitor Carvalho Valadares e Lucas Gomes Rodrigues</p>

# Menu Principal
Na Tela Inical do Menu Principal temos 4 botões clicáveis
- Jogar (Representado por um icone de play) -> Inicia o jogo
- Opções (Representado por um icone de engrenagem) -> Abre o Menu de Opções (Próximo tópico)
- Sair (Representado por um icone de porta) -> Fecha o jogo
- Idioma (Representado pela bandeira no canto da tela) -> Altera o idioma do jogo (Não implementado)

<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/menu1.png?raw=true"</p>

## Menu de Configurações
- No Menu de Configurações temos as configurações dos Gráficos, dos Sons, da jogabilidade e da acessiblidade.
- Alternando entre as opções, usando o teclado ou o mouse, podemos alterar as opções do submenu lateral.
- Esse menu também será acessivel durante o jogo, através de um menu de pause.
	
<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/menu2.png?raw=true"></p>

### Gráficos (Não implementado)
- Aqui será possivel alterar a resolução e outras opções relacionadas aos gráficos do jogo.

### Sons (Não implementado)
- Aqui será possivel alterar o volume da música e dos efeitos sonoros do jogo.

### Acessibilidade (Parcialmente implementado)
- Aqui será possivel ativar e configurar as opções de acessibilidade explicadas no próximo tópico:

<p align="center"><img src="https://github.com/TP-Coltec-UFMG/2022-303-NomeADefinir/blob/main/Imagens/menu3.png?raw=true"></p>

# Acessibilidade
Um dos pontos mais importante do projeto é que seja um jogo acessível e divertido para todos. Nossa jogo contará com opções para que pessoas com quase qualquer tipo de necessidade especial consiga jogar e se divertir, tais opções são:

## Acessiblidade para jogadores com baixa visão
- Alto contraste
	- A opção de alto contraste ajudará essas pessoas deixando os elementos principais e essenciais do jogo mais visíveis e perceptíveis. O jogo se passará num fundo marrom que representa a Árvore e, tanto os personagens jogaveis quanto os inimigos e obstaculos possuirão cores vivas e distantas. 
	
- Tamanho de fonte ajustável
  - Cada jogador poderá escolher o tamanho de fonte mais adequado para si, para que não perca nenhuma informação importante ou parte da história porque simplesmente não conseguiu ler.

- Áudio stereo e em frequencias diferentes
  - O áudio no nosso jogo não será essencial para a gameplay, porém será de grande ajuda caso alguem precise depender dele. O jogo terá um áudio stereo que corresponderá com a localização de elementos chaves no jogo como inimigos e "power-ups". Além disso teremos o cuidado de deixar a frequência dos diferentes áudios no jogo bastante separadas e distintas. Dessa forma, mesmo que haja muitos elementos na tela, o jogador ainda conseguirá distinguir cada um deles. 
  
## Acessibilidade para pessoas com daltonismo (de todos os tipos)
- Mudança na paleta de cor
	- Para que todos consigam distinguir as cores do jogo, teremos opções para cada tipo de daltonismo, que alterará a paleta de cor de cada cenário de acordo com a necessidade. Usaremos como base [este site](https://www.color-blindness.com/coblis-color-blindness-simulator/) para termos certeza de que cada paleta esta de acordo com as necessidades.
  
## Acessibilidade para jogadores com problemas motores
- Jogabilidade simples
  - O nosso jogo contará com controles extremamente simples para que todos consigam jogar sem serem prejudicados por qualquer outro motivo. Existirá apenas uma possibilidade de input por parte do jogador: pular. Dessa forma apenas um único botão será usado e não exigirá grande coordenação motora.
- Diversão
  - Apesar de ter controles simples, o jogo será desafiador e divertido, exigindo rápida tomada de decisões. O jogo contará com um corônometro para incentivar a competividade e com alguns elementos aleatórios para diversificar a gameplay.

## Acessibilidade para deficientes auditivos
- Descrição do áudio
  - Para que pessoa com dificuldades de escutar possam estar a par de tudo que está acontecendo tanto quanto as outras, haverá uma opção de descrição de áudio, onde sons do ambiente relevantes seram descritos em texto.
# Notas
- Por mais que todas as opções de acessibilidade estão no menu, a maioria ainda não foi implementada pois não temos um protótipo do jogo pronto ainda.
- Apesar de termos uma ideia sólida do que o jogo será, tudo ainda está sujeito à mudanças, logo tudo que está aqui pode (e provavelmente vai) mudar.
