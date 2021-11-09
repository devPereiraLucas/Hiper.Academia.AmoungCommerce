<template>
  <Header/>
  <router-view />
  <Footer />
</template>

<script>
  import Header from './components/Header.vue'
  import Footer from './components/Footer.vue'

  export default {
    components: {
      Header,
      Footer
    },
    data() {
      return {
        app_name: "A biblioteca online para você"
      }
    }
  }
</script>

<style>
  @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600&display=swap');

  :root {
    --header-height: 3rem;

    --hue-color: 20; /*Purple 250 - Green 142 - Blue 230 - Pink 340*/

    --first-color: hsl(var(--hue-color), 100%, 44%);
    --first-color-alt: hsl(var(--hue-color), 100%, 36%);
    --first-color-lighter: hsl(var(--hue-color), 92%, 85%);
    --title-color: hsl(var(--hue-color), 8%, 15%);
    --text-color: hsl(var(--hue-color), 8%, 45%);
    --text-color-dark-light: hsl(var(--hue-color), 1%, 18%);
    --text-color-light: hsl(var(--hue-color), 8%, 100%);
    --input-color: hsl(var(--hue-color), 70%, 96%);
    --body-color: hsl(var(--hue-color), 60%, 99%);
    --container-color: #DADADA;
    --card-color: hsl(var(--hue-color), 60%, 99%);

    --body-font: Poppins, sans-serif;

    /* .5rem = 8px, 1rem = 16px, 1.5rem = 24px ... */
    --big-font-size: 2rem;
    --h1-font-size: 1.5rem;
    --h2-font-size: 1.25rem;
    --h3-font-size: 1.125rem;
    --normal-font-size: .938rem;
    --small-font-size: .813rem;
    --smaller-font-size: .75rem;

    /*Font weight*/
    --font-ligth: 200;
    --font-medium: 500;
    --font-semi-bold: 600;

    /* Margens Bottom */
    /* .25rem = 4px, .5rem = 8px, .75rem = 12px ... */
    --mb-0-25: .25rem;
    --mb-0-5: .5rem;
    --mb-0-75: .75rem;
    --mb-1: 1rem;
    --mb-1-5: 1.5rem;
    --mb-2: 2rem;
    --mb-2-5: 2.5rem;
    --mb-3: 3rem;
    --mb-5: 5rem;

    /* z index */
    --z-tooltip: 10;
    --z-fixed: 100;
    --z-modal: 1000;
  }

  /* Font size mobile large */
  @media screen and (min-width: 968px) {
    :root {
      --big-font-size: 3rem;
      --h1-font-size: 2.25rem;
      --h2-font-size: 1.5rem;
      --h3-font-size: 1.25rem;
      --normal-font-size: 1rem;
      --small-font-size: .875rem;
      --smaller-font-size: .813rem;
    }
  }

  /*BASE*/

  * {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
  }

  html {
    scroll-behavior: smooth;
  }

  body {
    margin: 0 0 var(--header-height) 0;
    font-family: var(--body-font);
    font-size: var(--normal-font-size);
    background-color: var(--body-color);
    color: var(--text-color);
    height: 100vh;
  }

  h1,h2,h3,h4 {
    color: var(--title-color);
    font-weight: var(--font-semi-bold);
  }

  ul {
    list-style: none;
  }

  a {
    text-decoration: none;
  }
</style>
