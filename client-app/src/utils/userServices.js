import axios from 'axios';

const url = 'https://localhost:5001/api/user/';

export default {
    getAll: async () => {
      axios.get()
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
    
    },
    postUser: async (data) => {
      axios({
        method: 'POST',
        url: url,
        data: data
      })
      .then(function (res) {
        console.log(res);
      })
      .catch(function (error) {
        console.log(error);
      });
    }
}