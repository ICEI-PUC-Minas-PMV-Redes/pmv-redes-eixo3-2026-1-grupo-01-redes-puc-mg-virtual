# Manual Técnico – Sistema de Monitoramento Ambiental (Cliente Web)

Este documento reúne, em um único passo a passo, todas as instruções técnicas necessárias para instalar, executar e preparar para produção o cliente web (dashboard) do sistema de monitoramento de temperatura e umidade da Flextronics da Amazônia.

---

# 1. Requisitos Técnicos

## 1.1 Software necessário
- Node.js 18 ou superior  
- NPM (instalado junto com o Node.js)  
- Navegador atualizado (Chrome, Edge ou Firefox)  
- Visual Studio Code (opcional, mas recomendado)  

## 1.2 Estrutura do projeto

A pasta `codigo/cliente` contém:

```
cliente/
 ├─ node_modules/
 ├─ src/
 ├─ index.html
 ├─ package.json
 ├─ package-lock.json
 ├─ tailwind.config.js
 ├─ postcss.config.js
```

Tecnologias utilizadas:
- Vite (servidor de desenvolvimento)
- TailwindCSS (estilização)
- HTML + JavaScript (front-end)

---

# 2. Instalação do Cliente

## 2.1 Acessar a pasta do cliente

Abra o terminal e execute:

```bash
cd codigo/cliente
```

## 2.2 Instalar dependências

```bash
npm install
```

Esse comando instala todas as dependências listadas no `package.json`.

---

# 3. Execução do Cliente (Ambiente de Desenvolvimento)

## 3.1 Iniciar o servidor de desenvolvimento

```bash
npm run dev
```

Se tudo estiver correto, aparecerá algo como:

```
VITE v4.x.x  ready in xxx ms
➜  Local:   http://localhost:5173/
```

## 3.2 Acessar o dashboard

Abra o navegador e acesse:

```
http://localhost:5173/
```

O dashboard será carregado exibindo:
- Sensores ativos  
- Sensores em alerta  
- Sensores offline  
- Última atualização  
- Cartões individuais de sensores  

---

# 4. Build para Produção

## 4.1 Gerar o build

```bash
npm run build
```

Isso criará a pasta:

```
cliente/dist/
```

## 4.2 Publicar o build

Os arquivos da pasta `dist` podem ser publicados em:
- Servidor Apache  
- Servidor Nginx  
- IIS  
- Servidor interno da empresa  
- Container Docker (se configurado)  

---

# 5. Solução de Problemas (Troubleshooting)

## 5.1 Porta ocupada

```bash
npm run dev -- --port=3000
```

Acesse:

```
http://localhost:3000/
```

## 5.2 Node ou NPM não encontrados

Instale o Node.js em:

```
https://nodejs.org/
```

Depois verifique:

```bash
node -v
npm -v
```

## 5.3 Dashboard não carrega (tela em branco)

1. Pressione F12 no navegador.  
2. Abra a aba Console.  
3. Verifique erros de JavaScript ou rede.  
4. Confirme se o servidor está rodando (`npm run dev`).  

## 5.4 Erros ao rodar `npm install`

Tente:

```bash
rm -rf node_modules
rm package-lock.json
npm install
```

(No Windows, exclua manualmente.)

---

# 6. Contato Técnico

Responsável: **Thyago Lima – Gestor IT**  
Setor: Tecnologia da Informação  
Local: Flextronics da Amazônia  

---

# 7. Resumo Rápido (Checklist)

1. Instalar Node.js  
2. `cd codigo/cliente`  
3. `npm install`  
4. `npm run dev`  
5. Acessar `http://localhost:5173/`  
6. Para produção: `npm run build` e publicar `dist/`  
