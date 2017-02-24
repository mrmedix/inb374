/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package entities;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author Bjorn
 */
@Entity
@Table(name = "Part")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Part.findAll", query = "SELECT p FROM Part p"),
    @NamedQuery(name = "Part.findByDescription", query = "SELECT p FROM Part p WHERE p.description = :description"),
    @NamedQuery(name = "Part.findByLeadDays", query = "SELECT p FROM Part p WHERE p.leadDays = :leadDays")})
public class Part implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 25)
    @Column(name = "Description")
    private String description;
    @Basic(optional = false)
    @NotNull
    @Column(name = "LeadDays")
    private int leadDays;

    public Part() {
    }

    public Part(String description) {
        this.description = description;
    }

    public Part(String description, int leadDays) {
        this.description = description;
        this.leadDays = leadDays;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public int getLeadDays() {
        return leadDays;
    }

    public void setLeadDays(int leadDays) {
        this.leadDays = leadDays;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (description != null ? description.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Part)) {
            return false;
        }
        Part other = (Part) object;
        if ((this.description == null && other.description != null) || (this.description != null && !this.description.equals(other.description))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "entities.Part[ description=" + description + " ]";
    }
    
}
