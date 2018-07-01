<template>
    <aside class="col-md-4">
        <widget v-for="widget in widgets" :data="widget"></widget>
    </aside>
</template>

<script>

    import Widget from '../components/Widget.vue'

    export default {
        components: { Widget },
        data() { 
            return {
                widgets: [
                    {
                        title: 'Foo',
                        items: [
                            { url: '#', content: 'item-1' },
                            { url: '#', content: 'item-2' },
                            { url: '#', content: 'item-3' }
                        ],
                        style: 'left-icon'
                    },
                    {
                        title: 'Bar',
                        items: [
                            { url: '#', content: 'item-1' },
                            { url: '#', content: 'item-2' },
                            { url: '#', content: 'item-3' }
                        ],
                        style: 'calendar-icon'
                    },
                    {
                        title: 'Baz',
                        items: [
                            { url: '#', content: 'item-1' },
                            { url: '#', content: 'item-2' },
                            { url: '#', content: 'item-3' }
                        ],
                        style: 'check-icon'
                    }
                ]
            }
        }
    }

</script>