SELECT Id, Title, Content, CreateDateTime
FROM Journal;

SELECT *
FROM Blog;

SELECT *
FROM Post;

SELECT p.Id,
p.Title,
p.URL,
p.PublishDateTime,
p.AuthorId,
p.BlogId
FROM Post p
LEFT JOIN PostTag pt on p.Id = pt.PostId
LEFT JOIN Tag t on t.Id = pt.TagId
LEFT JOIN Post on Author.Id = Post.AuthorId;
