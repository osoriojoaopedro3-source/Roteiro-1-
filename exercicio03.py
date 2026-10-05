# Exercício 03 - Classe Produto


class Produto:
    def __init__(self, nome, preco, quantidade):
        self.nome = nome
        self.preco = preco
        self.quantidade = quantidade

    def exibir_dados(self):
        print(f"Produto: {self.nome}")
        print(f"Preço: R$ {self.preco:.2f}")
        print(f"Quantidade: {self.quantidade}")

    def calcular_valor_total(self):
        return self.preco * self.quantidade


produtos = [
    Produto("Caneta", 2.50, 10),
    Produto("Caderno", 18.90, 3),
    Produto("Mochila", 129.99, 1),
]

for produto in produtos:
    produto.exibir_dados()
    print(f"Valor total: R$ {produto.calcular_valor_total():.2f}")
    print()
