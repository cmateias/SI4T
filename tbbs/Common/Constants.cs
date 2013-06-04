﻿using System;

namespace SI4T.Templating
{
    public static class Constants
    {
        //Package item names
        public const string PACKAGE_ITEM_SEARCHDATA = "SI4T.Templating.SearchData";
        public const string PACKAGE_ITEM_CUSTOMFIELDS = "SI4T.Templating.CustomFields";
        public const string PACKAGE_ITEM_EXCLUDE_FIELDS_BY_DEFAULT = "SI4T.Templating.ExcludeFieldsByDefault";
        public const string PACKAGE_ITEM_MIN_TEMPLATE_PRIO_FOR_INDEXING = "SI4T.Templating.MinTemplatePrioForIndexing";
        public const string PACKAGE_ITEM_MANAGED_FIELDS = "SI4T.Templating.ManagedFields";

        //Context variable names
        public const string CONTEXT_VARIABLE_FLAGGED_DCPS = "SI4T.Templating.FlaggedDcps";

        //Field names
        public const string FIELD_NOINDEX = "NoIndex";
        public const string FIELD_INCLUDEEXCLUDE = "SearchIndexInclude";
        public const string FIELD_MANAGEDFIELDS = "SearchIndexManagedFields";
        public const string FIELD_CUSTOMFIELDMAP = "SearchIndexCustomFieldMap";
        public const string FIELD_LINKFIELDSTOEMBED = "SearchIndexLinkFieldsToEmbed";
        
        //Field values
        public const string FIELDVALUE_INCLUDE = "[include]";
        public const string FIELDVALUE_EXCLUDE = "[exclude]";

        //Delimiters
        public const string DELIMITER_PATTERN_SEARCHDATA = " INDEX-DATA-START:{0}:INDEX-DATA-END ";
        
        //XML Namspaces
        public const string NAMESPACE_XHTML = "http://www.w3.org/1999/xhtml";
        public const string NAMESPACE_XLINK = "http://www.w3.org/1999/xlink";
        public const string NAMESPACE_TCDL = "http://www.tridion.com/ContentDelivery/5.3/TCDL";
        public const string NAMESPACE_TRIDION = "http://www.tridion.com/ContentManager/5.0";
        
    }
}
