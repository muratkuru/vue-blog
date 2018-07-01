<template>
    <article class="post">
        <header class="entry-header">
            <h1 class="entry-title">
                <a :href="data.url">{{ data.title }}</a>
            </h1>
            <div class="entry-meta">
                <span class="post-category">
                    <a href="#">{{ data.category }}</a>
                </span>

                <span class="post-date">
                    <a href="#">
                        <time class="entry-date" datetime="2012-11-09T23:15:57+00:00">{{ data.date }}</time>
                    </a>
                </span>

                <span class="post-author">
                    <a href="#">{{ data.author }}</a>
                </span>

                <span class="comments-link">
                    <a href="#">{{ data.commentCount }} Comments</a>
                </span>
            </div>
        </header>
        <div class="entry-content clearfix">
            <p>{{ data.content }}</p>
            <div class="read-more cl-effect-14">
                <a :href="data.url" class="more-link">Continue reading
                    <span class="meta-nav">→</span>
                </a>
            </div>
        </div>
    </article>
</template>

<script>

    export default { 
        props: {
            data: { type: Object, required: true }
        }
    }

</script>