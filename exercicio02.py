# Exercício 02 - Classe Fantasma (PAC-MAN)


class Fantasma:
    def __init__(self, nick, cor, habilidade):
        self.nick = nick
        self.cor = cor
        self.habilidade = habilidade

    def gerar_fantasma(self):
        print("Fantasma gerado!")
        print(f"  Nick: {self.nick}")
        print(f"  Cor: {self.cor}")
        print(f"  Habilidade: {self.habilidade}")

    def mover(self, direcao: str):
        print(f"{self.nick} se moveu para {direcao}")


blinky = Fantasma("Blinky", "Vermelho", "Persegue o Pac-Man diretamente")
pinky = Fantasma("Pinky", "Rosa", "Tenta emboscar o Pac-Man pela frente")
inky = Fantasma("Inky", "Ciano", "Movimento imprevisível")
clyde = Fantasma("Clyde", "Laranja", "Foge quando chega perto")

for fantasma in (blinky, pinky, inky, clyde):
    fantasma.gerar_fantasma()
    print()

blinky.mover("cima")
pinky.mover("esquerda")
inky.mover("direita")
clyde.mover("baixo")
