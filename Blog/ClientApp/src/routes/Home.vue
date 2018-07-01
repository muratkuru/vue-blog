<template>
    <div class="blog-wrapper">
        <main class="col-md-8">
            <div class="posts">
                <post v-for="post in posts" :data="post"></post>
            </div>
        </main>
        <sidebar></sidebar>
    </div>
</template>

<script>

    import Post from '../components/Post.vue'
    import Sidebar from '../components/Sidebar.vue'

    export default {
        name: 'Home',
        components: { Post, Sidebar },
        data() { 
            return {
                posts: []
            }
        },
        methods: {
            getPosts() {
                this.$http.get('http://localhost:64528/api/blog/getallposts', function(data, status){
                  return data;
                });
            }
        },
        created() {
            this.posts = this.getPosts();
        }
    }

</script>
