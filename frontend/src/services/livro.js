import { http } from './config'

export default {
    listarTodos: () => {
        return http.get('listarTodos')
    }
}