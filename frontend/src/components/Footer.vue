<template>
  <footer class="footer">
    <p>Ecommerce de livros by Lucas &copy;2021</p>
  </footer>
</template>

<script>
export default {
  name: 'Footer',
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.footer {
  background: #333333;
  color: var(--text-color-light);
  text-align: right;
  padding: 1.56rem 5rem;
  text-transform: lowercase;
  font-size: var(--small-font-size);
}
</style>
