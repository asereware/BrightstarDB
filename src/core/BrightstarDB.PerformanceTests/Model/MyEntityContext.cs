﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;


namespace BrightstarDB.PerformanceTests.Model 
{
    public partial class MyEntityContext : BrightstarEntityContext {
    	
    	static MyEntityContext() 
    	{
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(BrightstarDB.PerformanceTests.Model.IArticle));
    		EntityMappingStore.Instance.SetImplMapping<BrightstarDB.PerformanceTests.Model.IArticle, BrightstarDB.PerformanceTests.Model.Article>();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(BrightstarDB.PerformanceTests.Model.IDepartment));
    		EntityMappingStore.Instance.SetImplMapping<BrightstarDB.PerformanceTests.Model.IDepartment, BrightstarDB.PerformanceTests.Model.Department>();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(BrightstarDB.PerformanceTests.Model.IJobRole));
    		EntityMappingStore.Instance.SetImplMapping<BrightstarDB.PerformanceTests.Model.IJobRole, BrightstarDB.PerformanceTests.Model.JobRole>();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(BrightstarDB.PerformanceTests.Model.IPerson));
    		EntityMappingStore.Instance.SetImplMapping<BrightstarDB.PerformanceTests.Model.IPerson, BrightstarDB.PerformanceTests.Model.Person>();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(BrightstarDB.PerformanceTests.Model.ISkill));
    		EntityMappingStore.Instance.SetImplMapping<BrightstarDB.PerformanceTests.Model.ISkill, BrightstarDB.PerformanceTests.Model.Skill>();
    		provider.AddMappingsForType(EntityMappingStore.Instance, typeof(BrightstarDB.PerformanceTests.Model.IWebsite));
    		EntityMappingStore.Instance.SetImplMapping<BrightstarDB.PerformanceTests.Model.IWebsite, BrightstarDB.PerformanceTests.Model.Website>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified BrightstarDB
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the BrightstarDB Data Object Store that will provide the entity objects</param>
    	public MyEntityContext(IDataObjectStore dataObjectStore) : base(dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
        /// <param name="updateGraphUri">OPTIONAL: The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// not defined, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">OPTIONAL: The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If not defined, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">OPTIONAL: The URI identifier of the graph that contains version number statements for entities. 
        /// If not defined, the <paramref name="updateGraphUri"/> will be used.</param>
    	public MyEntityContext(
    	    string connectionString, 
    		bool? enableOptimisticLocking=null,
    		string updateGraphUri = null,
    		IEnumerable<string> datasetGraphUris = null,
    		string versionGraphUri = null
        ) : base(connectionString, enableOptimisticLocking, updateGraphUri, datasetGraphUris, versionGraphUri)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public MyEntityContext() : base()
    	{
    		InitializeContext();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration and the
    	//  specified target graphs
    	/// </summary>
        /// <param name="updateGraphUri">The URI identifier of the graph to be updated with any new triples created by operations on the store. If
        /// set to null, the default graph in the store will be updated.</param>
        /// <param name="datasetGraphUris">The URI identifiers of the graphs that will be queried to retrieve entities and their properties.
        /// If set to null, all graphs in the store will be queried.</param>
        /// <param name="versionGraphUri">The URI identifier of the graph that contains version number statements for entities. 
        /// If set to null, the value of <paramref name="updateGraphUri"/> will be used.</param>
    	public MyEntityContext(
    		string updateGraphUri,
    		IEnumerable<string> datasetGraphUris,
    		string versionGraphUri
    	) : base(updateGraphUri:updateGraphUri, datasetGraphUris:datasetGraphUris, versionGraphUri:versionGraphUri)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		Articles = 	new BrightstarEntitySet<BrightstarDB.PerformanceTests.Model.IArticle>(this);
    		Departments = 	new BrightstarEntitySet<BrightstarDB.PerformanceTests.Model.IDepartment>(this);
    		JobRoles = 	new BrightstarEntitySet<BrightstarDB.PerformanceTests.Model.IJobRole>(this);
    		Persons = 	new BrightstarEntitySet<BrightstarDB.PerformanceTests.Model.IPerson>(this);
    		Skills = 	new BrightstarEntitySet<BrightstarDB.PerformanceTests.Model.ISkill>(this);
    		Websites = 	new BrightstarEntitySet<BrightstarDB.PerformanceTests.Model.IWebsite>(this);
    	}
    	
    	public IEntitySet<BrightstarDB.PerformanceTests.Model.IArticle> Articles
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.PerformanceTests.Model.IDepartment> Departments
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.PerformanceTests.Model.IJobRole> JobRoles
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.PerformanceTests.Model.IPerson> Persons
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.PerformanceTests.Model.ISkill> Skills
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.PerformanceTests.Model.IWebsite> Websites
    	{
    		get; private set;
    	}
    	
        public IEntitySet<T> EntitySet<T>() where T : class {
            var itemType = typeof(T);
            if (typeof(T).Equals(typeof(BrightstarDB.PerformanceTests.Model.IArticle))) {
                return (IEntitySet<T>)this.Articles;
            }
            if (typeof(T).Equals(typeof(BrightstarDB.PerformanceTests.Model.IDepartment))) {
                return (IEntitySet<T>)this.Departments;
            }
            if (typeof(T).Equals(typeof(BrightstarDB.PerformanceTests.Model.IJobRole))) {
                return (IEntitySet<T>)this.JobRoles;
            }
            if (typeof(T).Equals(typeof(BrightstarDB.PerformanceTests.Model.IPerson))) {
                return (IEntitySet<T>)this.Persons;
            }
            if (typeof(T).Equals(typeof(BrightstarDB.PerformanceTests.Model.ISkill))) {
                return (IEntitySet<T>)this.Skills;
            }
            if (typeof(T).Equals(typeof(BrightstarDB.PerformanceTests.Model.IWebsite))) {
                return (IEntitySet<T>)this.Websites;
            }
            throw new InvalidOperationException(typeof(T).FullName + " is not a recognized entity interface type.");
        }
    
        } // end class MyEntityContext
        
}
namespace BrightstarDB.PerformanceTests.Model 
{
    
    public partial class Article : BrightstarEntityObject, IArticle 
    {
    	public Article(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
    	public Article() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IArticle
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    
    	public System.String BodyText
    	{
            		get { return GetRelatedProperty<System.String>("BodyText"); }
            		set { SetRelatedProperty("BodyText", value); }
    	}
    
    	public System.Nullable<System.DateTime> PublishDate
    	{
            		get { return GetRelatedProperty<System.Nullable<System.DateTime>>("PublishDate"); }
            		set { SetRelatedProperty("PublishDate", value); }
    	}
    
    	public BrightstarDB.PerformanceTests.Model.IPerson Publisher
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IPerson>("Publisher"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IPerson>("Publisher", value); }
    	}
    
    	public BrightstarDB.PerformanceTests.Model.IWebsite Website
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IWebsite>("Website"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IWebsite>("Website", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    
    public partial class Department : BrightstarEntityObject, IDepartment 
    {
    	public Department(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
    	public Department() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IDepartment
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.Int32 DeptId
    	{
            		get { return GetRelatedProperty<System.Int32>("DeptId"); }
            		set { SetRelatedProperty("DeptId", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IPerson>("Persons"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    
    public partial class JobRole : BrightstarEntityObject, IJobRole 
    {
    	public JobRole(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
    	public JobRole() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IJobRole
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IPerson> Persons
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IPerson>("Persons"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Persons", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    
    public partial class Person : BrightstarEntityObject, IPerson 
    {
    	public Person(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
    	public Person() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IPerson
    
    	public System.String Fullname
    	{
            		get { return GetRelatedProperty<System.String>("Fullname"); }
            		set { SetRelatedProperty("Fullname", value); }
    	}
    
    	public System.Int32 Age
    	{
            		get { return GetRelatedProperty<System.Int32>("Age"); }
            		set { SetRelatedProperty("Age", value); }
    	}
    
    	public System.Int32 Salary
    	{
            		get { return GetRelatedProperty<System.Int32>("Salary"); }
            		set { SetRelatedProperty("Salary", value); }
    	}
    
    	public System.DateTime DateOfBirth
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateOfBirth"); }
            		set { SetRelatedProperty("DateOfBirth", value); }
    	}
    
    	public System.Int32 EmployeeNumber
    	{
            		get { return GetRelatedProperty<System.Int32>("EmployeeNumber"); }
            		set { SetRelatedProperty("EmployeeNumber", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.ISkill> Skills
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.ISkill>("Skills"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Skills", value); }
    								}
    
    	public BrightstarDB.PerformanceTests.Model.IDepartment Department
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IDepartment>("Department"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IDepartment>("Department", value); }
    	}
    
    	public BrightstarDB.PerformanceTests.Model.IJobRole JobRole
    	{
            get { return GetRelatedObject<BrightstarDB.PerformanceTests.Model.IJobRole>("JobRole"); }
            set { SetRelatedObject<BrightstarDB.PerformanceTests.Model.IJobRole>("JobRole", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IArticle> Articles
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IArticle>("Articles"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Articles", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    
    public partial class Skill : BrightstarEntityObject, ISkill 
    {
    	public Skill(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
    	public Skill() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.ISkill
    
    	public System.String Description
    	{
            		get { return GetRelatedProperty<System.String>("Description"); }
            		set { SetRelatedProperty("Description", value); }
    	}
    
    	public System.String Title
    	{
            		get { return GetRelatedProperty<System.String>("Title"); }
            		set { SetRelatedProperty("Title", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IPerson> SkilledPeople
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IPerson>("SkilledPeople"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("SkilledPeople", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.PerformanceTests.Model 
{
    
    public partial class Website : BrightstarEntityObject, IWebsite 
    {
    	public Website(BrightstarEntityContext context, BrightstarDB.Client.IDataObject dataObject) : base(context, dataObject) { }
    	public Website() : base() { }
    	public System.String Id { get {return GetKey(); } set { SetKey(value); } }
    	#region Implementation of BrightstarDB.PerformanceTests.Model.IWebsite
    
    	public System.String Name
    	{
            		get { return GetRelatedProperty<System.String>("Name"); }
            		set { SetRelatedProperty("Name", value); }
    	}
    
    	public System.String Url
    	{
            		get { return GetRelatedProperty<System.String>("Url"); }
            		set { SetRelatedProperty("Url", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.PerformanceTests.Model.IArticle> Articles
    	{
    		get { return GetRelatedObjects<BrightstarDB.PerformanceTests.Model.IArticle>("Articles"); }
    		set { if (value == null) throw new ArgumentNullException("value"); SetRelatedObjects("Articles", value); }
    								}
    	#endregion
    }
}
