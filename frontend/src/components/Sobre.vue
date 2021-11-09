<template>
    <section class="about">
        <h2 class="about__title">Os melhores autores, tudo em um só lugar!</h2>
        <h3 class="about__description">Tudo sobre teoria musical, com clareza e simplicidade. 
            Livros de teoria musical na prática, sem complicações.
        </h3>
  </section>
</template>

<style scoped>
.about {
  text-align: center;
  padding: 2.5rem;
}

.about__title {
  color: var(--first-color);
}

.about__description {
  color: var(--text-color-dark-light);
  font-weight: var(--font-ligth);
}

@media screen and (min-width: 0) {
    .about__title {
      font-size: var(--normal-font-size);
    }

    .about__description {
      font-size: var(--small-font-size);
    }
}

@media screen and (min-width: 767px) {
  .about__title {
    font-size: var(--h1-font-size);
  }

  .about__description {
    font-size: var(--h3-font-size);
  }
}
</style>