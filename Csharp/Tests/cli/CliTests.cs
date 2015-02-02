using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

using System.Text;
using System.IO;

namespace Tests.cli
{
    [TestFixture]
    public class CliTests : EditorConfigTests
    {
        private IEnumerable<string> _files;

        [SetUp]
        public void SetUp()
        {
            _files = InFiles("cli");
        }

        [Test]
        public void Test()
        {
            
        }
        /*
        # test --version option returns version information
add_test(test_long_version_switch ${EDITORCONFIG_CMD} --version)
set_tests_properties(test_long_version_switch PROPERTIES
    PASS_REGULAR_EXPRESSION
    "^EditorConfig.* Version [0-9]+\\.[0-9]+\\.[0-9]+(-[a-z]+)?[ \t\n\r]$")

# test -v option returns version information
add_test(test_short_version_switch ${EDITORCONFIG_CMD} -v)
set_tests_properties(test_short_version_switch PROPERTIES
    PASS_REGULAR_EXPRESSION
    "^EditorConfig.* Version [0-9]+\\.[0-9]+\\.[0-9]+(-[a-z]+)?[ \t\n\r]$")

# Test for multiple input files

# when files are specified on command line
add_test(multiple_files_on_command_line ${EDITORCONFIG_CMD} -f cli.in
    "${CMAKE_CURRENT_SOURCE_DIR}/file1.c"
    "${CMAKE_CURRENT_SOURCE_DIR}/file2.cpp")
set_tests_properties(multiple_files_on_command_line PROPERTIES
    PASS_REGULAR_EXPRESSION
    "^\\[${CMAKE_CURRENT_SOURCE_DIR}/file1.c\\][ \t]*[\n\r]+key1=value1[ \t]*[\n\r]+\\[${CMAKE_CURRENT_SOURCE_DIR}/file2.cpp\\][ \t]*[\n\r]+key2=value2[ \t\n\r]*$")
    
        */
    }
}
