<template>
  <header class="header">
    <img class="logo__img" src="../assets/logo.png" alt="logo da loja virtual de livros musicais">
    <!--<nav class="menu">
      <ul class="menu__list">
        <li class="menu__item"><router-link class="menu__link" to="/">Home</router-link></li>
        <li class="menu__item"><router-link class="menu__link" to="/Contato">Contato</router-link></li>
      </ul>
    </nav>-->
  </header>
</template>

<script>
  export default {
    name: 'Header',

    data () {
      return {
        
      }
    },

    methods: {
      
    },

    computed: {
      
    }
  }
</script>

<style scoped>
.header {
  align-items: center;
  background: var(--container-color);
  display: flex;
  justify-content: flex-start;
  padding: 0 2rem;
}

.logo__img {
  width: 125px;
}

.menu__list {
  display: flex;
}

.menu__item:last-child .menu__link {
  margin-right: 0;
}

.menu__link {
  color: var(--first-color);
  margin-right: 1.25rem;
  text-decoration: none;
}

.router-link-exact-active {
  color: var(--text-color-dark-light);
  margin-right: 1.25rem;
  text-decoration: none;
  font-weight: var(--font-semi-bold);
}

.menu__link:hover {
  text-decoration: underline;
}


@media screen and (min-width: 0) {
  .header {
    padding: 0 1rem;
    justify-content: center;
  }
}

@media screen and (min-width: 767px) {
  .header {
    padding: 0 5rem;
    justify-content: flex-start;
  }
}
</style>
