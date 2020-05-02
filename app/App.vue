<template>
  <div>
      <table>
          <tbody>
              <tr v-for="todo in todos" v-bind:key="todo">
                   <td>{{todo.CODEVALUACION}}</td>                   
                   <td>{{todo.EVALUACION}}</td>
                   <td>{{todo.OBS}}</td>
                   <td>{{todo.Edad}}</td>                                     
              </tr>
          </tbody>
      </table>
  </div>
</template>

<script>
import axios from  'axios'
export default {
    data(){
      return {

         todos:null

      }
    },
    mounted(){
   console.log('hola que tal ')
   this.getTodos();
    },
    methods:{
     getTodos(){
         console.log('antes de la llamada al webapi')
         axios.get('http://localhost:8081/webapi/api/EVALUACION_TED/')
         .then(response => {
            this.todos = response.data

         })
         .catch(e => console.log(e))
     }

    }
    

}
</script>

<style>

</style>