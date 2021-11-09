<template>
  <section class="banner">
    <img class="banner__img" src="../assets/banner_home.png" alt="">
    <h2 class="banner__title">{{banner_titulo}}</h2>
  </section>
</template>

<script>
export default {
  name: 'Banner',
  props: ["banner_img", "banner_titulo"],
}
</script>

<style scoped>
.banner {
  position: relative;
}

.banner__img {
  width: 100%;
}

.banner__title {
  color: var(--text-color-light);
  position: absolute;
  left: 50%;
  top: 50%;
  text-shadow: 0 4px 4px rgba(0, 0, 0, 0.80);
  text-align: center;
  transform: translate(-50%, -50%);
  width: 100%;
}

@media screen and (min-width: 0) {
  .banner__img {
    height: calc(100vh - 51px);
  }
}

@media screen and (min-width: 767px) {
  .banner__img {
    height: calc(100vh - 70px);
  }

  .banner__title {
    font-size: var(--big-font-size);
  }
}
</style>