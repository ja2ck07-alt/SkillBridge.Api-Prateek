public class JobRepository : IJobRepository
{
     public async Task<IEnumerable<JobDto>> GetJobListAsync()

    {
  return new List<JobDto>
       {
        new JobDto {ID = 1, Name ="Software Engineer",
         Description = "Develop and maintain software applications"},
        new JobDto {ID = 2,Name ="Product Manager",
         Description = "Manage product development and strategy"}
       };
         
    }
}