# Especificação da Solução

## 1. Parceiro / Comunidade

### 1.1 Identificação

| Campo | Descrição |
|-------|-----------|
| **Nome da comunidade/organização** | Flextronics da Amazônia |
| **Tipo de organização** | Empresa Privada |
| **CNPJ (se aplicável)** | *(Não informado)* |
| **Endereço completo** | Av. Torquato Tapajós - Colônia Terra Nova, Manaus - AM, 69027-000 |
| **Bairro / Cidade / UF** | Colônia Terra Nova / Manaus / AM |
| **Responsável pelo contato** | Thyago Lima (Gestor IT) |
| **E-mail** | *(Não informado)* |
| **Telefone** | *(Não informado)* |
| **Data do primeiro contato** | *(Não informado)* |

### 1.2 Contexto da Comunidade

A Flextronics da Amazônia é uma empresa do setor de manufatura eletrônica responsável pela produção de dispositivos como celulares Motorola e laptops HP. A unidade de Manaus atende principalmente às empresas Motorola e HP, impactando diretamente mais de 2.000 colaboradores envolvidos em processos de produção, qualidade e infraestrutura tecnológica.

A empresa possui sensores de temperatura e umidade instalados em diversos setores, e parte das métricas é visualizada por ferramentas como Grafana e Zabbix. No entanto, o monitoramento encontra-se distribuído, dificultando a centralização das informações, a correlação de eventos e o gerenciamento eficiente de alertas. Esse cenário aumenta o risco de falhas em equipamentos sensíveis e compromete a tomada de decisão rápida.

### 1.3 Termo de Parceria

O termo de parceria foi discutido com os representantes da Flextronics durante as reuniões iniciais com Thyago Lima (Information Technology Manager) e Jorenilson Santos (Sênior Tec Support Analyst). O documento será arquivado na pasta `evidencias/termos/` assim que disponibilizado.

- [ ] Termo de parceria assinado e arquivado em `evidencias/termos/`

---

## 2. Problema Identificado

A Flextronics possui sensores de temperatura e umidade distribuídos pela fábrica, mas o monitoramento dessas métricas não é centralizado. Atualmente, os dados são visualizados em diferentes plataformas (Grafana e Zabbix), dificultando a análise integrada e a identificação rápida de anomalias.

Essa falta de centralização aumenta o risco de falhas em equipamentos sensíveis, pode gerar impactos na produção e dificulta o trabalho de técnicos e supervisores responsáveis pelo controle ambiental. A ausência de uma visão unificada compromete a eficiência operacional e a tomada de decisão.

---

## 3. Solução Proposta

### 3.1 Descrição Geral

A solução consiste no desenvolvimento de um sistema centralizado de monitoramento de temperatura e umidade, utilizando coleta de dados via SNMP e integração com o Zabbix. A plataforma contará com:

- API em .NET para ingestão e consulta de dados  
- Dashboard web para visualização em tempo real  
- Banco PostgreSQL para armazenamento histórico  
- Sistema de alertas automáticos  
- Coleta ativa via SNMPv2c/v3  
- Integração com Zabbix para triggers e notificações  

A solução permitirá consolidar informações atualmente distribuídas, melhorar a gestão de alertas e fornecer uma visão integrada do ambiente industrial.

### 3.2 Objetivos

**Objetivo geral:**  
Centralizar o monitoramento de temperatura e umidade da fábrica, garantindo maior visibilidade, segurança operacional e tomada de decisão rápida.

**Objetivos específicos:**

1. Integrar sensores existentes via SNMP.  
2. Consolidar dados em um banco centralizado.  
3. Exibir métricas em tempo real em um dashboard único.  
4. Emitir alertas automáticos quando limites críticos forem ultrapassados.  
5. Permitir análise histórica para identificação de tendências.  
6. Reduzir riscos de falhas em equipamentos sensíveis.  

### 3.3 Escopo da Solução

**Dentro do escopo:**
- Coleta de dados via SNMP  
- Integração com Zabbix  
- API .NET  
- Dashboard web  
- Banco PostgreSQL  
- Sistema de alertas  
- Documentação completa  

**Fora do escopo:**
- Instalação física dos sensores  
- Desenvolvimento de hardware  
- Monitoramento de variáveis além de temperatura/umidade  
- Integração com sistemas internos da Flextronics além do Zabbix  

### 3.4 Tipo de Solução

- [ ] Shell scripts para automação de tarefas de rede  
- [x] Back-end com API (.NET / outra tecnologia)  
- [x] Front-end web (HTML + CSS + JS)  
- [ ] Aplicação móvel  
- [ ] Configuração de infraestrutura de rede  
- [x] Outro: Integração com Zabbix via SNMP  

### 3.5 Justificativa Técnica

A escolha pelo Zabbix se baseia na sua capacidade nativa de coleta via SNMP, sistema robusto de alertas e armazenamento histórico. A API em .NET oferece escalabilidade, segurança e facilidade de manutenção. O PostgreSQL foi escolhido por sua eficiência no armazenamento de séries temporais. O dashboard web garante acessibilidade e centralização, atendendo às necessidades da equipe de TI e qualidade.

---

## 4. Requisitos

### 4.1 Requisitos Funcionais

| ID | Descrição | Prioridade |
|----|-----------|------------|
| RF01 | Permitir a coleta de dados de temperatura e umidade via SNMP. | Alta |
| RF02 | Exibir métricas em tempo real em um dashboard centralizado. | Alta |
| RF03 | Enviar alertas automáticos quando limites críticos forem ultrapassados. | Alta |
| RF04 | Registrar e armazenar histórico de leituras. | Média |
| RF05 | Permitir consulta de gráficos históricos por setor. | Média |

### 4.2 Requisitos Não Funcionais

| ID | Descrição | Categoria |
|----|-----------|-----------|
| RNF01 | O sistema deve operar continuamente sem interrupções. | Disponibilidade |
| RNF02 | O dashboard deve atualizar informações com baixa latência. | Desempenho |
| RNF03 | O acesso ao sistema deve ser restrito a usuários autorizados. | Segurança |
| RNF04 | O banco deve suportar grande volume de séries temporais. | Escalabilidade |
| RNF05 | A interface deve ser intuitiva para técnicos e supervisores. | Usabilidade |

---

## 5. Arquitetura da Solução

A arquitetura é composta por quatro camadas:

1. **Camada de Apresentação**  
   Dashboard web, relatórios históricos e sistema de notificações.

2. **Camada de Aplicação**  
   Poller SNMP, motor de triggers, scripts de hardening e health check.

3. **Camada de Persistência**  
   Banco PostgreSQL otimizado para séries temporais.

4. **Camada de Infraestrutura**  
   Sensores industriais, SNMPv2c/v3, ACLs e firewall.

---

## 6. Cronograma do Projeto

| Atividade | Responsável | Início | Fim | Status |
|-----------|-------------|--------|-----|--------|
| Levantamento de requisitos | Tallis | 01/03/2026 | 05/03/2026 | Concluído |
| Prototipação | Breno | 06/03/2026 | 12/03/2026 | Concluído |
| Desenvolvimento do servidor | Tallis | 13/03/2026 | 30/03/2026 | Em andamento |
| Desenvolvimento do cliente | Breno | 20/03/2026 | 10/04/2026 | Pendente |
| Testes | Tallis | 16/04/2026 | 25/04/2026 | Pendente |
| Documentação | Breno | 20/04/2026 | 30/04/2026 | Pendente |
| Apresentação | Tallis e Breno | 01/05/2026 | 05/05/2026 | Pendente |

---

## 7. Riscos Identificados

| Risco | Probabilidade | Impacto | Mitigação |
|-------|--------------|---------|-----------|
| Falha na comunicação SNMP | Média | Alto | Implementar retries e logs. |
| Atraso na validação com o cliente | Alta | Médio | Agendar reuniões com antecedência. |
| Volume elevado de dados históricos | Média | Médio | Otimizar banco e criar rotinas de limpeza. |
| Falhas no envio de alertas | Baixa | Alto | Redundância e logs de falha. |
| Curva de aprendizado do Zabbix | Média | Baixo | Uso de templates e documentação oficial. |
