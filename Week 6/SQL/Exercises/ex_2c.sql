select * from tblAuthor

select * from tblEpisode


create or alter procedure spMoffats 
as 
begin
	select * from tblEpisode where AuthorId in (select AuthorId from tblAuthor where AuthorName = 'Steven Moffat') order by EpisodeDate desc
end

exec spMoffats

create or alter procedure spMoffats 
as 
begin
	select e.EpisodeId, e.SeriesNumber, e.EpisodeNumber, e.EpisodeType, e.Title, e.EpisodeDate, e.AuthorId, e.DoctorId, e.Notes 
	from tblEpisode e
	inner join 
	tblAuthor a 
	on
	e.AuthorId = a.AuthorId 
	where AuthorName = 'Steven Moffat'
	order by e.EpisodeDate desc
end