<!DOCTYPE html>
<html lang="pt-BR">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>TaskFlow — README.md</title>
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=DM+Sans:wght@400;500;600&family=Space+Grotesk:wght@400;500;600;700&display=swap" rel="stylesheet">
<style>
:root{--paper:#f5f3ec;--ink:#202923;--muted:#59665c;--accent:#245b3d;--line:#d6dcd1}
*{box-sizing:border-box}
body{margin:0;background:var(--paper);color:var(--ink);font-family:'DM Sans',sans-serif}
main{max-width:1000px;margin:auto;padding:42px 24px 60px}
header{display:flex;justify-content:space-between;align-items:center;border-bottom:1px solid var(--line);padding-bottom:22px;gap:20px}
.brand{font-family:'Space Grotesk',sans-serif;font-weight:700;font-size:21px}
.label{font-size:12px;letter-spacing:.12em;text-transform:uppercase;color:var(--muted)}
.intro{padding:54px 0 30px;animation:reveal .6s both}
h1{font-family:'Space Grotesk',sans-serif;font-size:clamp(40px,7vw,72px);letter-spacing:-.055em;line-height:1.05;margin:12px 0 20px}
p{color:var(--muted);line-height:1.7;max-width:640px}
.toolbar{display:flex;justify-content:space-between;align-items:center;gap:16px;padding:18px 0;border-top:1px solid var(--line)}
.filename{font-family:'Space Grotesk',sans-serif;font-weight:600}
button{border:0;background:var(--accent);color:white;padding:13px 20px;font:600 14px 'DM Sans',sans-serif;cursor:pointer;transition:transform .2s,background .2s}
button:hover{background:#173f29;transform:translateY(-2px)}
button:active{transform:translateY(1px)}
button:focus-visible,textarea:focus-visible{outline:3px solid #a6b954;outline-offset:4px}
textarea{display:block;width:100%;height:650px;resize:vertical;border:1px solid var(--line);background:#fffefa;padding:25px;color:var(--ink);font:14px/1.8 'Space Grotesk',sans-serif;tab-size:2;animation:reveal .7s .1s both}
footer{display:flex;justify-content:space-between;gap:20px;margin-top:22px;font-size:13px;color:var(--muted)}
#status{color:var(--accent)}
@keyframes reveal{from{opacity:0;transform:translateY(12px)}to{opacity:1;transform:translateY(0)}}
@media(max-width:540px){main{padding:24px 18px}header .label{display:none}.intro{padding-top:35px}textarea{padding:16px}footer{flex-direction:column}}
@media(prefers-reduced-motion:reduce){*{animation:none!important;transition:none!important}}
</style>
</head>
<body>
<main>
<header><span class="brand">TaskFlow<span style="color:var(--accent)"> /</span></span><span class="label">Documentação do projeto</span></header>
<section class="intro">
<span class="label">Console + xUnit · .NET 10</span>
<h1>Seu projeto.<br>Bem documentado.</h1>
<p>Copie o conteúdo abaixo e salve como <strong>README.md</strong> na raiz do repositório <strong>taskflow-console</strong>. Ajuste as funcionalidades descritas se sua implementação for diferente.</p>
</section>
<section aria-label="Conteúdo do README">
<div class="toolbar"><label for="readme" class="filename">README.md</label><button id="copy" type="button">Copiar README ↗</button></div>
<textarea id="readme" spellcheck="false" aria-label="README em Markdown editável"># TaskFlow Console

Aplicação console para gerenciamento de tarefas (To-Do List), desenvolvida em C# com .NET 10 e testes unitários com xUnit.

Projeto acadêmico da disciplina de Garantia da Qualidade de Software / Gestão e Qualidade de Software, ministrada pelo professor Daniel Henrique Matos de Paiva.

## Objetivo

Aplicar boas práticas de desenvolvimento e qualidade de software por meio de uma aplicação console, testes automatizados e um histórico de commits organizado com Conventional Commits.

## Funcionalidades

- Adicionar tarefas.
- Listar tarefas cadastradas.
- Buscar tarefas por ID.
- Concluir tarefas.
- Interagir com a aplicação por um menu no console.
- Validar títulos, impedindo o cadastro de tarefas com título vazio ou nulo.
- Retornar `null` quando uma tarefa não for encontrada pelo ID.

As tarefas são armazenadas em memória. Os dados não são persistidos após o encerramento da aplicação.

## Tecnologias

- C#
- .NET 10
- xUnit
- Git e GitHub

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Git](https://git-scm.com/downloads)

Verifique a instalação:

```bash
dotnet --version
git --version
