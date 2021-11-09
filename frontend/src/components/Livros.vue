<template>
    <section class="book__container" id="book-container">
        <div class="book" v-for="livro of livros" :key="livro.id">
            <img alt="" class="book__img" :src="livro.imageUrl" />
            <div class="book__content">
                <h4 class="book__title">{{ livro.titulo }}</h4>
                <p class="book__author">Autor: {{ livro.autor }}</p>
                <p class="book__nivel" :class="livro.nivel">Nivel: {{ livro.nivel }}</p>
                <p class="book__price">Valor: R${{ livro.preco }}</p>
                <a class="book__btn" :href="`https://api.whatsapp.com/send?phone=5547992893113&text=Estou%20interessando%20neste%20livro%20aqui%3A%20${livro.titulo}%2C%20do%20autor%3A%20${livro.autor}`" target="_blank">Comprar</a>
            </div>
        </div>
    </section>
</template>

<script>
import Livro from '../services/livro'
    
export default {
    name: "Livros",
    data() {
        return {
        livros: []
        }
    },

    mounted() {
        Livro.listarTodos().then(response => {
            console.log(response.data)
            this.livros = response.data
        })
    }
}
</script>

<style scoped>
.book__container {
    background: var(--container-color);
    display: flex;
    flex-wrap: wrap;
}

.book {
    background: var(--card-color);
    display: flex;
    flex-direction: column;
    margin-bottom: var(--mb-5);
    border-radius: 10px;
}

.book__img {
    height: 250px;
    border-radius: 10px 10px 0 0;
}

.book__content {
   padding: 1rem;
   display: flex;
   flex-direction: column;
   justify-content: space-between;
   height: 100%;
}

.book__title {
    font-size: var(--normal-font-size);
}

.book__author {
    font-size: var(--smaller-font-size);
    font-style: italic;
}

.book__nivel {
    font-size: var(--small-font-size);
    line-height: 1.5;
}

.Iniciante {
    color: hsl(121, 94%, 29%);
}

.Intermediario {
    color: hsl(46, 100%, 51%);
}

.Avançado {
    color: hsl(0, 99%, 42%)
}

.book__price {
    color: var(--text-color-dark-light);
}

.book__btn {
    background: var(--first-color);
    font-size: var(--small-font-size);
    border-radius: 5px;
    color: var(--text-color-light);
    padding: .75rem;
    transition: all .1s ease-in-out;
    text-transform: uppercase;
    text-align: center;
}

.book__btn:hover {
    background: var(--first-color-alt);
    cursor: pointer;
}

@media screen and (min-width: 0) {
    .book__container {
        padding: 5rem 3rem 0 3rem;
    }

    .book {
        width: 100%;
        margin-right: 1rem;
    }
}

@media screen and (min-width: 767px) {
    .book__container {
        padding: 5rem 0 0 2.5rem;
    }
    .book {
        width: 100%;
        margin-right: 2.5rem;
        width: calc(33.33% - 2.5rem);
    }
}

@media screen and (min-width: 992px) {
    .book__container {
        padding: 5rem 0 0 5rem;
    }
    .book {
        margin-right: 5rem;
        width: calc(25% - 5rem);
    }
}
</style>