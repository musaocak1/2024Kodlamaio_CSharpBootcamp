using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Intro.DataAccess.Abstracts;
using _01_Intro.DataAccess.Concretes;
using _01_Intro.Entities;

namespace _01_Intro.Business;

public class CourseManager
{
    //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }


    public List<Course> GetAll()
    {
        //business rules

        return _courseDal.GetAll();
    }
}