# Exercício 01 - Classe Funcionario com atributo cargo


class Funcionario:
    def __init__(self, nome, idade, cargo):
        self.nome = nome
        self.idade = idade
        self.cargo = cargo  # a) novo atributo

    def apresentar(self):
        print(f"Olá, meu nome é {self.nome}, tenho {self.idade} anos e sou {self.cargo}.")

    # c) o salário não é atributo: é calculado a partir do cargo
    def informar_salario(self):
        salarios = {
            "Gerente": 10000.00,
            "Desenvolvedor": 5000.00,
            "Estagiário": 100.00,
        }
        salario = salarios.get(self.cargo)
        if salario is None:
            print(f"Cargo '{self.cargo}' não possui salário cadastrado.")
        else:
            valor = f"{salario:,.2f}".replace(",", "X").replace(".", ",").replace("X", ".")
            print(f"{self.nome} ({self.cargo}) recebe R$ {valor}")


# b) três objetos com os cargos pedidos
f1 = Funcionario("Ana", 40, "Gerente")
f2 = Funcionario("Bruno", 28, "Desenvolvedor")
f3 = Funcionario("Carla", 20, "Estagiário")

for f in (f1, f2, f3):
    f.apresentar()
    f.informar_salario()
    print()
