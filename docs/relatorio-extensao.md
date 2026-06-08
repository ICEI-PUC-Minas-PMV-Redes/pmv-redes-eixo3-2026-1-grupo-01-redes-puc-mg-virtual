# Relatório da Disciplina de Extensão

> Relatório final da atividade extensionista desenvolvida no âmbito da disciplina de Desenvolvimento de Sistema para Redes de Computadores, conforme exigências da curricularização da extensão (Resolução CNE/CES nº 7/2018).

---

## 1. Dados da Atividade

| Campo | Descrição |
|-------|-----------|
| **Instituição** | Pontifícia Universidade Católica de Minas Gerais (PUC Minas) |
| **Curso** | Curso Superior de Tecnologia em Redes de Computadores |
| **Disciplina** | Desenvolvimento de Sistema para Redes de Computadores |
| **Eixo** | 3 |
| **Semestre/Ano** | 3º Semestre / 2026 |
| **Professor(a) orientador(a)** | Harison Herman Silva |
| **Carga horária de extensão** | 40h |

---

## 2. Equipe Executora

| Nome Completo | Matrícula | E-mail Institucional |
|---------------|-----------|----------------------|
| Tallis Bruce Rodrigues Oliveira | *(Matrícula)* | *(E-mail)* |
| Breno Neves Colto | *(Matrícula)* | *(E-mail)* |

---

## 3. Comunidade Parceira

| Campo | Descrição |
|-------|-----------|
| **Nome** | Flextronics Internacional |
| **Tipo** | Empresa |
| **Endereço** | Av. Torquato Tapajós - Colônia Terra Nova, Manaus - AM, 69027-000 |
| **Responsável** | *(Nome + cargo — ex.: Gestor de TI)* |
| **Contato** | 92 9 9206-3174 |
| **Público atendido** | Setor de Qualidade |

---

## 4. Resumo da Atividade

O projeto teve como objetivo apoiar o setor de Qualidade da Flextronics Internacional por meio do desenvolvimento de um sistema de monitoramento ambiental voltado para temperatura e umidade em ambientes críticos. A partir do contato com a comunidade parceira, foi identificado o problema da ausência de uma visualização centralizada e em tempo real dos sensores, bem como a necessidade de alertas automáticos para situações de risco.

Como solução, foi proposto e desenvolvido um dashboard web que apresenta o status dos sensores, indicadores de alerta e histórico de medições, além de integração com dispositivos via SNMP. As ações envolveram levantamento de requisitos junto ao setor de Qualidade, especificação técnica, desenvolvimento de front-end e back-end, testes com dados simulados e ajustes conforme feedback da comunidade.

Os resultados incluem uma ferramenta que facilita o acompanhamento das condições ambientais, melhora a tomada de decisão e contribui para a formação prática dos alunos na área de redes e desenvolvimento de sistemas.

---

## 5. Objetivos

### 5.1 Objetivo Geral

Desenvolver um sistema de monitoramento ambiental (dashboard web) para apoiar o setor de Qualidade da Flextronics Internacional no acompanhamento de sensores de temperatura e umidade.

### 5.2 Objetivos Específicos

1. Criar um dashboard para visualização de sensores.  
2. Implementar alertas automáticos para condições críticas.  
3. Integrar sensores via SNMP para coleta de dados em tempo real.  

---

## 6. Fundamentação Teórica

O projeto se fundamenta em conceitos de redes de computadores, protocolos de gerenciamento de dispositivos (como SNMP), desenvolvimento de sistemas web e monitoramento ambiental em ambientes corporativos. A utilização de SNMP permite a coleta de informações de dispositivos de rede e sensores, viabilizando o acompanhamento remoto de variáveis como temperatura e umidade.

No front-end, foram aplicados conceitos de desenvolvimento de interfaces responsivas e usabilidade, utilizando tecnologias modernas como Vite e TailwindCSS. No back-end, foram considerados princípios de comunicação entre serviços, tratamento de dados e integração com fontes de informação.

Os microfundamentos da disciplina — como protocolos de aplicação, arquitetura cliente-servidor, segurança em redes e boas práticas de documentação — foram diretamente aplicados na concepção e implementação da solução, garantindo alinhamento entre teoria e prática.

---

## 7. Metodologia

A metodologia adotada seguiu uma abordagem incremental, iniciando pelo contato com a comunidade parceira para entendimento das necessidades do setor de Qualidade. Em seguida, foi realizado o levantamento de requisitos por meio de conversas, reuniões e análise do contexto operacional da Flextronics Internacional.

Com base nesses requisitos, o grupo elaborou a especificação do sistema, definindo funcionalidades principais, indicadores a serem exibidos no dashboard e critérios de alerta. As etapas de desenvolvimento foram divididas em: configuração do ambiente de desenvolvimento, criação da interface web utilizando Vite e TailwindCSS, implementação da lógica de monitoramento e integração com sensores via SNMP, e testes com dados simulados.

As interações com a comunidade incluíram validação das telas, ajustes de layout e discussão sobre a forma de apresentação dos dados. A documentação foi produzida em paralelo, contemplando manuais técnico e de usuário, além de registros das atividades extensionistas.

---

## 8. Cronograma Executado

| Atividade | Período Planejado | Período Executado | Observações |
|-----------|-------------------|-------------------|-------------|
| Contato inicial com a comunidade | *(Data)* | *(Data)* | *(Obs.)* |
| Levantamento de requisitos | *(Data)* | *(Data)* | *(Obs.)* |
| Especificação e prototipação | *(Data)* | *(Data)* | *(Obs.)* |
| Desenvolvimento do back-end | *(Data)* | *(Data)* | *(Obs.)* |
| Desenvolvimento do front-end | *(Data)* | *(Data)* | *(Obs.)* |
| Testes e ajustes | *(Data)* | *(Data)* | *(Obs.)* |
| Documentação | *(Data)* | *(Data)* | *(Obs.)* |
| Apresentação | *(Data)* | *(Data)* | *(Obs.)* |

---

## 9. Resultados Alcançados

### 9.1 Resultados Técnicos

Foi entregue um dashboard web funcional para monitoramento de sensores de temperatura e umidade, com visualização em tempo real, indicadores de alerta, contagem de sensores ativos, em alerta e offline, além de histórico de leituras. Também
