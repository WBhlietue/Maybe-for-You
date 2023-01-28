package com.example.wensql;

import org.springframework.data.jpa.repository.config.EnableJpaRepositories;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@EnableJpaRepositories(basePackages = "com.example.wensql", entityManagerFactoryRef = "emf")
@Repository
public interface StudentRepository extends CrudRepository<Student, Long> {

}
