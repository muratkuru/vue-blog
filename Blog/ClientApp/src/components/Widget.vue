<template>
    <div class="widget">
        <h3 class="widget-title">{{ data.title }}</h3>
        <ul>
            <li v-for="item in data.items" :class="data.style">
                <a :href="item.url">
                    {{ item.content }}
                </a>
            </li>
        </ul>
    </div>
</template>

<script>

    export default {
        props: {
            data: { type: Object, required: true }
        }
    }

</script>

<style>

.widget {
    background: #fff;  
    padding: 30px 0 0;  
}

.widget ul {
    padding: 0;
    margin: 0;
    padding-left: 20px;
}

.widget ul li {
    list-style-type: none;
    position: relative;
    line-height: 170%;
    margin-bottom: 10px;
}

.widget-title {  
	font-size: 1.5em;  
	margin-bottom: 20px;  
	line-height: 1.6;  
	padding: 10px 0 0;
	font-weight: 400;
}

</style>