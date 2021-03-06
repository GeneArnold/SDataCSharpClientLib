using System;

namespace Sage.SData.Client.Metadata
{
    /// <summary>
    /// Defines an Enum property.
    /// </summary>
    public class SMEEnumProperty : SMEProperty
    {
        #region Constants

        /// <summary>
        /// Default average length for a time.
        /// </summary>
        /// <value>The default average length for a time, which is <b>0</b>.</value>
        public const int DefaultAverageLength = 0;

        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="SMEEnumProperty"/> class.
        /// </summary>
        public SMEEnumProperty() :
            this(String.Empty)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="SMEEnumProperty"/> class
        /// with the specified label.
        /// </summary>
        /// <param name="label">The label for the property.</param>
        public SMEEnumProperty(string label) :
            base(label)
        {
        }

        #region Overrides

        /// <summary>
        /// Returns the default average length (in characters) to use for this property.
        /// </summary>
        /// <returns>The default average length (in characters) to use for this property.</returns>
        protected override int GetDefaultAverageLength()
        {
            return DefaultAverageLength;
        }

        protected override string Suffix
        {
            get { return SDataResource.XmlConstants.EnumSuffix; }
        }

        /// <summary>
        /// Validates the specified value against the constraints of the property.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        protected override void OnValidate(object value)
        {
            base.OnValidate(value, typeof (Enum));
        }

        #endregion
    }
}