<template>
  <Banner :banner_titulo="banner_titulo" />
  <Sobre />
  <Livros />
</template>

<script>
  import Banner from '../components/Banner.vue'
  import Sobre from '../components/Sobre.vue'
  import Livros from '../components/Livros.vue'

  export default {
    components: {
      Banner,
      Sobre,
      Livros
    },

    data() {
      return {
        banner_titulo: "A maior livraria musical da América Latina."
      }
    }
  }
</script>

<style scoped>
</style>