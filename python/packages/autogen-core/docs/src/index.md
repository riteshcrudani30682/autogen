---
myst:
  html_meta:
    "description lang=en": |
      Top-level documentation for AutoGen, a framework for developing applications using AI agents
html_theme.sidebar_secondary.remove: false
sd_hide_title: true
---

<style>
.hero-title {
  font-size: 60px;
  font-weight: bold;
  margin: 2rem auto 0;
}

.wip-card {
  border: 1px solid var(--pst-color-success);
  background-color: var(--pst-color-success-bg);
  border-radius: .25rem;
  padding: 0.3rem;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 1rem;
}
</style>

# AutoGen

<div class="container">
<div class="row text-center">
<div class="col-sm-12">
<h1 class="hero-title">
AutoGen
</h1>
<h3>
A framework for building AI agents and multi-agent applications
</h3>
</div>
</div>
</div>

<div style="margin-top: 2rem;">

::::{grid} 1 1 2 2

:::{grid-item-card}
:shadow: none
:margin: 2 0 0 0

<div class="wip-card">

{fas}`triangle-exclamation` Work in progress
</div>

<div class="sd-card-title sd-font-weight-bold docutils">

{fas}`people-group;pst-color-primary`
AgentChat </div>
High-level API that includes preset agents and teams for building multi-agent systems.

```sh
pip install 'autogen-agentchat==0.4.0.dev6'
```

💡 *Start here if you are looking for an API similar to AutoGen 0.2*

+++

```{button-ref} user-guide/agentchat-user-guide/quickstart
:color: secondary

Get Started
```

:::
:::{grid-item-card} {fas}`cube;pst-color-primary` Core
:shadow: none
:margin: 2 0 0 0

Provides building blocks for creating asynchronous, event driven multi-agent systems.

```sh
pip install 'autogen-core==0.4.0.dev6'
```

+++

```{button-ref} user-guide/core-user-guide/quickstart
:color: secondary

Get Started
```

:::
::::

</div>

```{toctree}
:maxdepth: 3
:hidden:

user-guide/index
packages/index
reference/index
```
