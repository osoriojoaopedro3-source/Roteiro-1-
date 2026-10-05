# Exercício 04 - Classe ContaBancaria


class ContaBancaria:
    def __init__(self, titular, numero_conta, saldo=0.0):
        self.titular = titular
        self.numero_conta = numero_conta
        self.saldo = max(saldo, 0.0)  # não permite começar com saldo negativo

    def depositar(self, valor):
        if valor <= 0:
            print("Valor de depósito inválido.")
            return
        self.saldo += valor
        print(f"Depósito de R$ {valor:.2f} realizado na conta {self.numero_conta}.")

    def sacar(self, valor):
        if valor <= 0:
            print("Valor de saque inválido.")
        elif valor > self.saldo:
            print(f"Saque de R$ {valor:.2f} negado: saldo insuficiente na conta {self.numero_conta}.")
        else:
            self.saldo -= valor
            print(f"Saque de R$ {valor:.2f} realizado na conta {self.numero_conta}.")

    def exibir_saldo(self):
        print(f"Titular: {self.titular} | Conta: {self.numero_conta} | Saldo: R$ {self.saldo:.2f}")


conta1 = ContaBancaria("João", "0001-1", 500.00)
conta2 = ContaBancaria("Maria", "0002-2")

conta1.exibir_saldo()
conta2.exibir_saldo()
print()

conta1.depositar(250.00)
conta1.sacar(100.00)
conta1.sacar(1000.00)  # deve ser negado
conta1.exibir_saldo()
print()

conta2.depositar(80.00)
conta2.sacar(50.00)
conta2.sacar(40.00)  # deve ser negado
conta2.depositar(-10)  # valor inválido
conta2.exibir_saldo()
